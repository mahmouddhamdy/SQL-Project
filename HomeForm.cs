﻿using Microsoft.EntityFrameworkCore;
using OnlineExamination.Context;
using OnlineExamination.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace OnlineExamination
{
    public partial class HomeForm : Form
    {

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        ExaminationSystemDBContext context = new ExaminationSystemDBContext();
        string Email_student;
        Student? student;
       
    //    FinalMarkForm finalMarkForm = new FinalMarkForm();
        public HomeForm()
        {
            InitializeComponent();
            //  this.loginFrm = frm;
            this.FormClosing += (sender, e) => { this.context.Dispose(); };
            var testiid = config.AppSettings.Settings["StudentID"].Value;
            Trace.WriteLine(testiid);
        }

        
        private void Form2_Load(object sender, EventArgs e)
        {

            Email_student = config.AppSettings.Settings["StudentMail"].Value;
            student = context.Students.Include(s=>s.Dept).FirstOrDefault(s => s.Email == Email_student);

            LoadCourses();
            if (student?.Dept != null)
            {
                this.departmentLabel.Text = student.Dept.DepartmentName;

            }
            else {
                this.departmentLabel.Visible = false;

            }
            this.userName.Text = student?.Fname + ' ' + student?.Lname;

            this.Text = Email_student;
       




        }
        private void LoadCourses()
        {
            FinalMarkForm finalMarkForm = new FinalMarkForm();
            ExamInfoForm examInfo = new();
            
            var stud = context.Students.FirstOrDefault(s => s.Email == Email_student);

            var res = context.StudentCourses.Include(s => s.Course).ThenInclude(c=>c.Ins).Where(s => s.StudentId == stud!.StudentId).ToList();




            CourseSection[] courseSection = new CourseSection[res.Count];

            for (int i = 0; i < res.Count; i++)
            {

                string crsName ="";
                int crsID =-1;

                StringBuilder stringBuilder= new StringBuilder();
                foreach (var instructor in res[i].Course.Ins)
                {
                    stringBuilder.Append(instructor.InstructorName);
                    stringBuilder.Append(',');
                    
                }
                string instructorNames = stringBuilder.ToString();


                courseSection[i] = new CourseSection();

                courseSection[i].InsName = instructorNames;
                courseSection[i].CrsName = res[i].Course.CourseName;
                crsName = res[i].Course.CourseName;
                crsID = res[i].Course.CourseId;
               
                

                if (res[i].StudentGrade != null)
                {
                    courseSection[i].StartExamBtn.Visible = false;
                    courseSection[i].Gradevalue.Text = res[i].StudentGrade.ToString();

                    courseSection[i].AnswerExamBtn.Click += (sender, e) =>
                    {
                      this.Hide();
                      FinalMarkForm.CrsId = crsID;
                      finalMarkForm.Show();
                    };
                   
                }
                else
                {
                    courseSection[i].Gradelabel.Visible = false;
                    courseSection[i].Gradevalue.Visible = false;
                    courseSection[i].AnswerExamBtn.Visible = false;

                    
                    courseSection[i].StartExamBtn.Click += (s, e) =>
                    {
                        this.Hide();
                        ExamInfoForm.crsName = crsName;
                        FinalMarkForm.CrsId = crsID;
                        examInfo.Show();
                        
                        
                    };

                }

            

                this.flowLayoutPanel1.Controls.Add(courseSection[i]);

                
            }



        }
      
        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          

            Application.Exit();


        }
    }
}