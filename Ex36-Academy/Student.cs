using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_Academy
{
    public class Student : Person, IStudent
    {
        private IAcademy academy;
        public IAcademy Academy
        {
            get { return academy; }
            set { academy = value; }
        }
        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        
        public Student(IAcademy academy, string name) : base(name)
        {
            this.academy = academy;        
        }

        public void Update()
        {
            Message = ((Academy)academy).Message;
        }
    }
}
