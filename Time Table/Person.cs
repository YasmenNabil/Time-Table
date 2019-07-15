using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Time_Table
{
    public abstract class Person
    {
        protected string Name;
        protected int ID;
        protected string Phone;
        protected string Email;
        protected string Adress;
        public Person(int NId, string Nname, string Nphone, string Nemail, string ads)
        {
            Name = Nname;
            ID = NId;
            Phone = Nphone;
            Email = Nemail;
            Adress = ads;
        }
        
    }
    public class Instructor : Person
    {
        public static List<Instructor> Instructorlist = new List<Instructor>();

        public Instructor(int NId, string Nname, string Nphone, string Nemail, string ads)
            : base(NId, Nname, Nphone, Nemail, ads)
        {

        }
        public static bool checkIID(int id)
        {
            for (int i = 0; i < Instructorlist.Count; i++)
            {
                if (Instructorlist[i].getIid() == id)
                    return true;
            }
            return false;
        }
        public static int search(int id)
        {
            for (int i = 0; i < Instructorlist.Count; i++)
            {
                if (Instructorlist[i].getIid() == id)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void addNewInstructor(int id, string name, string Phone, string mail, string adress)
        {
            Instructorlist.Add(new Instructor(id,name, Phone, mail, adress));
        }
        public static void Edit(int id, string name, string phone, string mail, string address)
        {
            int ID = search(id);
            Instructorlist[ID].setIname(name);
            Instructorlist[ID].setIphone(phone);
            Instructorlist[ID].setIemail(mail);
            Instructorlist[ID].setIads(address);
        }

        public static void Delete(int id)
        {
            int ID = search(id);
            Instructorlist.RemoveAt(ID);
        }

        public int getIid()
        {
            return ID;
        }
        public string getIname()
        {
            return Name;
        }
        public string getIphone()
        {
            return Phone;
        }
        public string getIemail()
        {
            return Email;
        }
        public string getIads()
        {
            return Adress;
        }

        public void setIid(int i)
        {
            ID = i;
        }
        public void setIname(string n)
        {
            Name = n;
        }
        public void setIphone(string p)
        {
            Phone = p;
        }
        public void setIemail(string m)
        {
            Email = m;
        }
        public void setIads(string a)
        {
            Adress = a;
        }
    }
    public class Teacher_Assistant : Person
    {
        public static List<Teacher_Assistant> TAlist = new List<Teacher_Assistant>();

       

        
        public Teacher_Assistant (int NId, string Nname, string Nphone, string Nemail, string ads)
            : base(NId, Nname, Nphone, Nemail, ads)
        {

        }
        public static void addNewTA( int id, string name, string Phone, string mail, string adress)
        {
            TAlist.Add(new Teacher_Assistant(id,name, Phone, mail, adress));
        }
        public static bool checkTID(int id)
        {
            for (int i = 0; i < TAlist.Count; i++)
            {
                if (TAlist[i].getTAid() == id)
                    return true;
            }
            return false;
        }
        public static void Edit(int id, string name, string phone, string mail, string address)
        {
            int ID = search(id);
            TAlist[ID].settname(name);
            TAlist[ID].settphone(phone);
            TAlist[ID].settemail(mail);
            TAlist[ID].settads(address);
        }
        public void settid(int i)
        {
            ID = i;
        }
        public void settname(string n)
        {
            Name = n;
        }
        public void settphone(string p)
        {
            Phone = p;
        }
        public void settemail(string m)
        {
            Email = m;
        }
        public void settads(string a)
        {
            Adress = a;
        }
        public static int search(int id)
        {
            for (int i = 0; i < TAlist.Count; i++)
            {
                if (TAlist[i].getTAid() == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void DeleteTA(int id)
        {
            int ID = search(id);
           TAlist.RemoveAt(ID);
        }
        public string getTAname()
        {
            return Name;
        }
        public int getTAid()
        {
            return ID;
        }
        public string getTAads()
        {
            return Adress;
        }
        public string getTAphone()
        {
            return Phone;
        }
        public string getTAmail()
        {
            return Email;
        }
    }
    }
