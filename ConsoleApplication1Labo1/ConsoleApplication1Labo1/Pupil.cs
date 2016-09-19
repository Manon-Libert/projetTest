using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1Labo1
{
    class Pupil : Person
    {
        //attributs
        private int grade;

        // propriété
        public List<Activity> ListActivities {get; set;}
        public char[] TabEval{ get; set; }

        public int Grade
        {
            get
            { return grade; }

            set
            { grade = (value > 0 && value < 7) ? value : 1; }
        }
        
        //constructeur
        public Pupil (string name, int age, int grade): base(name,age)
        {
            Grade = grade;
            ListActivities = new List<Activity>();
            TabEval = new char[10];
        }

        public Pupil(string name, int age) : this(name, age, 1) { }
        
        // méthode

        public void AddActivity(Activity activity){
            ListActivities.Add(activity);}


        public override string ToString()
        {
            string chaine = base.ToString();
            if (ListActivities.Count() == 0) { chaine += " n'a pas encore choisi"; return chaine; }
            else{
                chaine += "a choisi les activités suivantes : ";
                foreach(Activity activity in ListActivities){
                    chaine += activity.ToString() + "\n";
                }
                return chaine;}
        }

        public void AddEvaluation(String title = null, char evaluation = 'S')
        {

        }



    }
}
