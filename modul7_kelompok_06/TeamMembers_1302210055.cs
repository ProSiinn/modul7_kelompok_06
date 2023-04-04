using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_06
{
    internal class TeamMembers_1302210055
    {
        public List<members> members;

        public TeamMembers_1302210055(List<members> members)
        {
            this.members = members;
        }

        public static void ReadJSON()
        {
            //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string json = File.ReadAllText("E:\\modul7_kelompok_06\\modul7_kelompok_06\\jurnal7_2_1302210055.json");
            TeamMembers_1302210055 team = JsonSerializer.Deserialize<TeamMembers_1302210055>(json);

            for (int i = 0; i < team.members.Count; i++)
            {
                Console.WriteLine("Anggota " + team.members[i].nim + team.members[i].firstName + team.members[i].lastName + team.members[i].gender + team.members[i].age);
            }
        }
    }
    public class members
    {
        public String nama { get; set; }
        public String nim { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public String age { get; set; }

        //public members(string nama, string nim, string firstName, string lastName, string gender, string age)
        //{
           // this.nama = nama;
            //this.nim = nim;
            //this.firstName = firstName;
           // this.lastName = lastName;
            //this.gender = gender;
            //this.age = age;
       // }
    }
}


