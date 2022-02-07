using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Configuration;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSqlDataClassesDataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSql.Properties.Settings.PanjututorialsdbConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            // InsertUniversities();
            // InsertStudents();
            // insertLectures();
            // InsertStudentLectureAssociations();
            // GetUniversityOfToni();
            // GetLecturesFromTom();
            // GetallStudentsFromYale();
            // GetAllUniversitiesWithTransgenders();
            //GetAllLecturesFromOslo();
            // UpdateTom();
            DeleteJami();
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);

            University oslo = new University();
            oslo.Name = "Oslo";
            dataContext.Universities.InsertOnSubmit(oslo);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University oslo = dataContext.Universities.First(un => un.Name.Equals("Oslo"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Karl", Gender = "male", University = oslo });
            students.Add(new Student { Name = "Tom", Gender = "male", University = yale });
            students.Add(new Student { Name = "Jami", Gender = "female", University = oslo });
            students.Add(new Student { Name = "Jame", Gender = "trans-gender", University = oslo });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void insertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssociations()
        {
            Student Carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Karl = dataContext.Students.First(st => st.Name.Equals("Karl"));
            Student Tom = dataContext.Students.First(st => st.Name.Equals("Tom"));
            Student Jami = dataContext.Students.First(st => st.Name.Equals("Jami"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Karl, Lecture = Math });

            StudentLecture slTom = new StudentLecture();
            slTom.Student = Tom;
            slTom.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(slTom);

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Jami, Lecture = History });

            dataContext.SubmitChanges();


            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityOfTom()
        {
            Student Tom = dataContext.Students.First(st => st.Name.Equals("Tom"));

            University TomisUniversity = Tom.University;

            List<University> universities = new List<University>();
            universities.Add(TomisUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetLecturesFromTom()
        {
            Student Tom = dataContext.Students.First(st => st.Name.Equals("Tom"));

            var tomLectures = from sl in Tom.StudentLectures select sl.Lecture;

            MainDataGrid.ItemsSource = tomLectures;
        }

       public void GetallStudentsFromYale()
        {
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }


        public void GetAllUniversitiesWithTransgenders()
        {
            var transgernderUniversities = from student in dataContext.Students
                                           join university in dataContext.Universities
                                           on student.University equals university
                                           where student.Gender == "trans-gender"
                                           select university;

            MainDataGrid.ItemsSource = transgernderUniversities;
        }

        public void GetAllLecturesFromOslo()
        {
            var lecturesFromOslo = from sl in dataContext.StudentLectures
                                   join student in dataContext.Students on sl.StudentId equals student.Id
                                   where student.University.Name == "Oslo"
                                   select sl.Lecture;


            MainDataGrid.ItemsSource = lecturesFromOslo;

        }


        public void UpdateTom()
        {
            Student Tom = dataContext.Students.FirstOrDefault(st => st.Name == "Tom");

            Tom.Name = "Antonio";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void DeleteJami()
        {
            Student Jami = dataContext.Students.FirstOrDefault(st => st.Name == "Jami");
            dataContext.Students.DeleteOnSubmit(Jami);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

    }
}
