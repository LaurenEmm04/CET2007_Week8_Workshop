using System;
using System.Collections.Generic;

namespace CET2007w8
{
    ///<summary>
    /// Patient class
    /// </summary>
    /// 
    public class Patient
    {
        int ID { get; set; }
        string Name { get; set; }
        int Severity { get; set; }
        bool IsRead { get; set; }

        public Patient(int id, string name, int severity, bool isread)
        {
            ID = id;
            Name = name;
            Severity = severity;
            IsRead = isread;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Severity: {Severity}";
        }
    }
    /// <summary>
    /// main
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patients = new List<Patient>();

            patients.Add(new Patient(1, "Geoff Phishy", 2, true));
            patients.Add(new Patient(2, "Harvey Hagan", 10, true));
            patients.Add(new Patient(3, "Jack Fawcett", 10, true));

        }
    }

}