using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Academy
{
    public class Academy : Organization, IAcademy
    {
        internal List<IStudent> students = new List<IStudent>();

        private string message;
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                Notify();
            }
        }
        
        public string address;
        public Academy(string name, string address) : base(name,address)
        {
                     
        }
    
        public void Attach(IStudent student)
        {
            students.Add(student);
        }

        public void Detach(IStudent student)
        {
            students.Remove(student);
        }

        public void Notify()
        {
            {
                foreach (Student student in students)
                {
                    student.Update();
                }
            }
        }
    }
}
