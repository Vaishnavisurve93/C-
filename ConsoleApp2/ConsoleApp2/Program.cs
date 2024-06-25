using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        // Patient class with properties
        internal class Patient
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            public string PhoneNumber { get; set; }
            public string State { get; set; }
            public string Pincode { get; set; }
            public string Department { get; set; }
        }

        // Program class containing the Main method and other methods
        internal class Program
        {
            static string SelectDepartment()
            {
                string[] departments = {
                "General",
                "ENT",
                "Cardiology",
                "Operation Theater",
                "Intensive care Unit"
            };
                int[] prices = { 400, 800, 1200, 5000, 6000 };

                while (true)
                {
                    Console.WriteLine("Select the department for the treatment:");
                    for (int i = 0; i < departments.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {departments[i]} : {prices[i]}");
                    }

                    if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= departments.Length)
                    {
                        return departments[choice - 1];
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select a valid department.");
                    }
                }
            }

            static Patient TakePatientDetails()
            {
            string department = SelectDepartment();
            Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter Gender: ");
                string gender = Console.ReadLine();
                Console.Write("Enter Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter Phone Number: ");
                string phoneNumber = Console.ReadLine();
                Console.Write("Enter State: ");
                string state = Console.ReadLine();
                Console.Write("Enter Pincode: ");
                string pincode = Console.ReadLine();

                return new Patient
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Gender = gender,
                    Age = age,
                    PhoneNumber = phoneNumber,
                    State = state,
                    Pincode = pincode,
                    Department = department
                };
            }

            static Patient SearchPatientByPhone(List<Patient> patients, string phoneNumber)
            {
                foreach (var patient in patients)
                {
                    if (patient.PhoneNumber == phoneNumber)
                    {
                        return patient;
                    }
                }
                return null;
            }

            static void DisplayPatientDetails(Patient patient)
            {
                if (patient != null)
                {
                Console.WriteLine($"Department: {patient.Department}");

                Console.WriteLine($"First Name: {patient.FirstName}");
                    Console.WriteLine($"Last Name: {patient.LastName}");
                    Console.WriteLine($"Gender: {patient.Gender}");
                    Console.WriteLine($"Age: {patient.Age}");
                    Console.WriteLine($"Phone Number: {patient.PhoneNumber}");
                    Console.WriteLine($"State: {patient.State}");
                    Console.WriteLine($"Pincode: {patient.Pincode}");
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
            }

            static void Main()
            {

                List<Patient> patients = new List<Patient>();

                // Collect details for at least 10 patients
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("\nEnter details for patient:");
                    Patient patient = TakePatientDetails();
                    patients.Add(patient);
                }

                // Search for a patient based on mobile number
                Console.Write("\nEnter the phone number to search for a patient: ");
                string searchPhone = Console.ReadLine();
                Patient foundPatient = SearchPatientByPhone(patients, searchPhone);
                DisplayPatientDetails(foundPatient);
            }
        }
    }

