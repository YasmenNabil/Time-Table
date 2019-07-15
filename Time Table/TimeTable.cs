using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Time_Table
{
    public class Data
    {
        public static List<Course> courselist = new List<Course>();
        public static void read()
        {
            
            
            FileStream fs = new FileStream("Course.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (sr.Peek() != -1)
            {
                string s = sr.ReadLine();
                string[] arr = s.Split(',');
                string id = arr[0];
                string lec = arr[1];
                string lab = arr[2];
                int pir = Convert.ToInt32(arr[3]);
                string inst = arr[4];
                string TA = arr[5];
                Course cc = new Course(id, lec, lab, pir, inst,TA);
                courselist.Add(cc);
            }
            fs.Close();
            FileStream fs1 = new FileStream("Instructor.txt", FileMode.Open);
            StreamReader sr1 = new StreamReader(fs1);
            while (sr1.Peek() != -1)
            {
                string s = sr1.ReadLine();
                string[] arr = s.Split(',');
                int id = int.Parse(arr[0]);
                string Name = arr[1];
                string Phone = arr[2];
                string mail = arr[3];
                string ads = arr[4];
                Instructor cc = new Instructor(id, Name, Phone, mail, ads);
                Instructor.Instructorlist.Add(cc);
            }
            sr1.Close();
            //fs1.Close();
            FileStream fsa = new FileStream("Room.txt", FileMode.Open);
            StreamReader sra = new StreamReader(fsa);
            while (sra.Peek() != -1)
            {
                string s = sra.ReadLine();
                string[] arr = s.Split(',');
                string id = arr[0];
                string num = arr[1];
                int cap = Convert.ToInt32(arr[2]);
                string plc = arr[4];
                string avlb = arr[3];
                Room cc = new Room(id, num, cap, avlb, plc);
                Room.roomlist.Add(cc);
            }
            sra.Close();
            fsa.Close();
            FileStream fst = new FileStream("TeacherAssestant.txt", FileMode.Open);
            StreamReader srt = new StreamReader(fst);
            while (srt.Peek() != -1)
            {
                string s = srt.ReadLine();
                string[] arr = s.Split(',');
                int id = int.Parse(arr[0]);
                string Name = arr[1];
                string Phone = arr[2];
                string mail = arr[3];
                string ads = arr[4];
               Teacher_Assistant cc = new Teacher_Assistant(id, Name, Phone, mail, ads);
               Teacher_Assistant.TAlist.Add(cc);
            }
            srt.Close();
            fst.Close();
        }
          public static void write()
        {
            TextWriter txt = new StreamWriter(@"Course.txt");
            for (int i = 0; i < courselist.Count; i++)
            {
                txt.WriteLine(courselist[i].getCid().ToString() + "," + courselist[i].getCLecname() + "," + courselist[i].getCLabname() + "," + courselist[i].getCprty().ToString() + "," + courselist[i].getInstructor()+","+courselist[i].getCTA());
            }
            txt.Close();
            TextWriter txt1 = new StreamWriter(@"Instructor.txt");
            for (int i = 0; i < Instructor.Instructorlist.Count; i++)
            {
                txt1.WriteLine(Instructor.Instructorlist[i].getIid().ToString() + "," + Instructor.Instructorlist[i].getIname() + "," + Instructor.Instructorlist[i].getIphone() + "," + Instructor.Instructorlist[i].getIemail() + "," + Instructor.Instructorlist[i].getIads());
            }
            txt1.Close();
            TextWriter txt2 = new StreamWriter(@"Room.txt");
            for (int i = 0; i < Room.roomlist.Count; i++)
            {
                txt2.WriteLine(Room.roomlist[i].getid() + "," + Room.roomlist[i].getRnum() + "," + Room.roomlist[i].getcap() + "," + Room.roomlist[i].gettype() + "," + Room.roomlist[i].getplace());
            }
            txt2.Close();

            TextWriter txt3 = new StreamWriter(@"TeacherAssestant.txt");
            for (int i = 0; i < Teacher_Assistant.TAlist.Count; i++)
            {
                txt3.WriteLine(Teacher_Assistant.TAlist[i].getTAid().ToString() + "," + Teacher_Assistant.TAlist[i].getTAname() + "," + Teacher_Assistant.TAlist[i].getTAphone() + "," + Teacher_Assistant.TAlist[i].getTAmail() + "," + Teacher_Assistant.TAlist[i].getTAads());
            }
            txt3.Close();
        }
    }
    public class TimeTable
    {
        public static int searchLec(string Lecname)
        {
            for (int i = 0; i < Data.courselist.Count; i++)
            {
                if (Data.courselist[i].getCLecname() == Lecname)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void Swap(string oldlec, string newlec)
        {
            int oldindex = searchLec(oldlec);
            int newindex = searchLec(newlec);
            Course temp = Data.courselist[oldindex];
            Data.courselist[oldindex] = Data.courselist[newindex];
            Data.courselist[newindex] = temp;
        }
        public static bool Priority(string newlec, string oldlec)
        {
            int oldindex = searchLec(oldlec);
            int newindex = searchLec(newlec);
            int newpir = Data.courselist[newindex].getCprty();
            int oldpir = Data.courselist[oldindex].getCprty();
            if (newpir > oldpir)
            {
                Swap(Data.courselist[oldindex].getCLecname(), Data.courselist[newindex].getCLecname());
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Course
    {
        private string Lecname;
        private string Labname;
        private string ID;
        private int Priority;
        private string InsName;
        private string Tasstant;
        //private Room CourseRoom;

        public Course()
        {
            Lecname = " ";
            Labname = "";
            ID = "";
            Priority = 0;
            InsName = "";
            Tasstant = "";

        }
        public Course(string Nid, string Nname, string Lab, int prio, string ins,string ta)
        {
            ID = Nid;
            Lecname = Nname;
            Priority = prio;
            InsName = ins;
            Labname = Lab;
            Tasstant = ta;
        }
        public void setCID(string i)
        {
            ID = i;
        }
        public void setlecname(string n)
        {
            Lecname = n;
        }
        public void setTA(string n)
        {
            Tasstant = n;
        }
        public void setlabname(string n)
        {
            Labname = n;
        }
        public void setCPriorty(int p)
        {
            Priority = p;
        }
        public void setCInstructor(string inst)
        {
            InsName = inst;
        }

        public string getCLecname()
        {
            return Lecname;
        }
        public string getCTA()
        {
            return Tasstant;
        }
        public string getCLabname()
        {
            return Labname;
        }
        public string getCid()
        {
            return ID;
        }
        public int getCprty()
        {
            return Priority;
        }
        public string getInstructor()
        {
            return InsName;
        }
        public static bool checkCID(string id)
        {
            for (int i = 0; i < Data.courselist.Count; i++)
            {
                if (Data.courselist[i].getCid() == id)
                    return true;
            }
            return false;
        }
        public static int search(string id)
        {
            for (int i = 0; i < Data.courselist.Count; i++)
            {
                if (Data.courselist[i].getCid() == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void addNewCourse(string id, string lecname, string labname, int piriority, string Instructor,string TA)
        {
            Data.courselist.Add(new Course(id, lecname, labname, piriority, Instructor,TA));
        }
        public static void Edit(string id, string lecname, string labname, int pirority, string Instructor,string TA)
        {
            int ID = search(id);
            Data.courselist[ID].setlabname(labname);
            Data.courselist[ID].setlecname(lecname);
            Data.courselist[ID].setCPriorty(pirority);
            Data.courselist[ID].setCInstructor(Instructor);
            Data.courselist[ID].setTA(TA);
        }
        public static void Delete(string id)
        {
            int ID = search(id);
            Data.courselist.RemoveAt(ID);
        }
    }

    public class Room
    {
        string Id;
        string Number;
        int Capacity;
        string Roomavlble;
        string place;
        public static List<Room> roomlist = new List<Room>();

        public Room(string Nid, string Nnumber, int Ncap, string typ, string plc)
        {
            Id = Nid;
            Number = Nnumber;
            Capacity = Ncap;
            Roomavlble = typ;
            place = plc;
        }
        public string getRnum()
        {
            return Number;
        }
        public string getid()
        {
            return Id;
        }
        public int getcap()
        {
            return Capacity;
        }
        public string getplace()
        {
            return place;
        }
        public string gettype()
        {
            return Roomavlble;
        }

        public void setRnum(string n)
        {
            Number = n;
        }
        public void setid(string i)
        {
            Id = i;
        }
        public void setcap(int c)
        {
            Capacity = c;
        }
        public void setplace(string p)
        {
            place = p;
        }
        public void settype(string t)
        {
            Roomavlble = t;
        }
        public static bool checkRID(string id)
        {
            for (int i = 0; i < roomlist.Count; i++)
            {
                if (roomlist[i].getid() == id)
                    return true;
            }
            return false;
        }
        public static int search(string id)
        {
            for (int i = 0; i < roomlist.Count; i++)
            {
                if (roomlist[i].getid() == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void addNewRoom(string Nid, string Nnumber, int Ncap, string typ, string plc)
        {
            roomlist.Add(new Room( Nid,  Nnumber, Ncap,  typ,  plc));
        }
        public static void Edit(string Nid, string Nnumber, int Ncap, string typ, string plc)
        {
            int ID = search(Nid);
            roomlist[ID].setid(Nid);
            roomlist[ID].setRnum(Nnumber);
            roomlist[ID].setcap(Ncap);
            roomlist[ID].setplace(plc);
            roomlist[ID].settype(typ);
        }
        public static void Delete(string id)
        {
            int ID = search(id);
            roomlist.RemoveAt(ID);
        }
    }

    public class Labratory : Room
    {

        public Labratory(string Nid, string Nnumber, int Ncap, string typ, string plc)
            : base(Nid, Nnumber, Ncap, typ, plc)
        {

        }
    }
}


    

