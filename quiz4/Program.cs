using System;
using System.IO;
enum typetrip { normal=1,vip=2}
class passenger
{
    public string noe_darkhast {get; set;}
    public string Name  // property
    { get; set; }
    public string lastname { get; set; }
    public string ssn { get; set; }
    public int birthday { get; set; }
    public int go { get; set; } 
    public int bargasht { get; set; }
    public string noe_vasile { get; set; }
    public int shomare_seat { get; }
    public typetrip type;
    public string  gheimat;
    public int age = 101 - birthday;
    public passenger(string noe_darkhast, string name,string lastname,string ssn,int birthday,int go,int bargasht,string noe_vasile)
    {
        this.noe_darkhast = noe_darkhast;
        Name = name;
        this.lastname = lastname;
        this.ssn= ssn;
        this.birthday = birthday;
        this.go = go;
        this.bargasht = bargasht;
        this.noe_vasile=noe_vasile;
    }
    
     void setpassengertype()
    {
        if((ssn[0]==0 && ssn[1]==0)||(ssn[9]==0 && ssn[10] ==0))
        {
            type = typetrip.vip;
        }
    }

    void seatnumber()
    {
        Random rnd = new Random();
        if (type == typetrip.vip)
        {
            
            if (age <= 40)
            {
               

                
                   shomare_seat=rnd.Next(100, 106); // returns random integers >= 10 and < 19
               
            }
            else
            {
                shomare_seat = rnd.Next(106, 111);
            }
        }
        else
        {
            shomare_seat=rnd.Next(111, 120);
        }
    }
    public void cost()
    {
        if (noe_darkhast == "economy")
        {
            if (type == typetrip.vip)
            {
                if (noe_vasile == "plane")
                {
                    gheimat = "1000$";
                }
                else
                {
                    gheimat = "100$";
                }
            }
            else if (type == typetrip.normal)

            {
                if (noe_vasile == "plane")
                {
                    gheimat = "200$";
                }
                else
                {
                    gheimat = "20$";
                }
            }
        }
        else if(noe_darkhast =="first class")
        {
            if (type == typetrip.vip)
            {
                if (noe_vasile == "plane")
                {
                    gheimat = "3000$";
                }
                else
                {
                    gheimat = "200$";
                }
            }
            else if (type == typetrip.normal)

            {
                if (noe_vasile == "plane")
                {
                    gheimat = "1500$";
                }
                else
                {
                    gheimat = "10$";
                }
            }
        }
    }
}
class program
{
    public static void Main()
    {
        Console.WriteLine("welcome.enter the address of your file");
        string file = "";
        do
        {       string path=Console.ReadLine();
                Console.WriteLine("enter the number");
                int n=int.Parse(Console.ReadLine());
                string text = System.IO.File.ReadAllText(path);
                string[] StringArray = text.Split(' ');
                string name=StringArray[0];
                string lastname=StringArray[1];
                string ssn=StringArray[2];
                int age=int.Parse(StringArray[3]);
                int raft=int.Parse(StringArray[4]);
                int bargasht=int.Parse(StringArray[5]);
                string noe_vasile=StringArray[6];
                string noe_darkhast="";
                if (n == 1)
                {
                     noe_darkhast = "economy";
                }
                else if(n == 2)
                {
                    noe_darkhast = "first class";
                }
                passenger x = new passenger(noe_darkhast, name, lastname, ssn, age, raft, bargasht, noe_vasile);
                x.cost();
                x.seatnumber();
                File.WriteAllText("text2.txt", text);
                Console.WriteLine("name:"+x.Name);
                Console.WriteLine("family name:" + x.lastname);
                Console.WriteLine("type:"+x.type);
                Console.WriteLine("type vasile" + x.noe_vasile);
            } while (file != "exit");
    }
}
