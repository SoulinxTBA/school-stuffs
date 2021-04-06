/*
 * Created by SharpDevelop.
 * User: Acer
 * Date: 18/11/2019
 * Time: 4:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace ISProject
{
	class Program
	{
		public static void Main()
		{
			
			DateTime now = DateTime.Now;
            Console.WriteLine(now);
            
            Console.WriteLine("\n\t\t   Welcome\n");
            Console.WriteLine("\tEscuela de Brigida Montessori Inc.\n\n");
            
			string user;
			string pass = "";
			Console.WriteLine("Username:");
			user = Console.ReadLine();
			Console.WriteLine("Password:");
			
				do
				{
    			ConsoleKeyInfo key = Console.ReadKey(true);
    			// Backspace Should Not Work
    			if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter) {
        				pass += key.KeyChar;
        				Console.Write("*");
    			}else{	 
       				if (key.Key == ConsoleKey.Backspace && pass.Length > 0){
           			pass = pass.Substring(0, (pass.Length - 1));
            		Console.Write("\b \b");
       			 }else if (key.Key == ConsoleKey.Enter){
    					break;
    					
       				 }
    			}
				} while (true);
				if (user == "admin" && pass == "admin"){
					Console.WriteLine("\nAccess Granted");
					Console.ReadLine();
					Console.Clear();
						Info();
				}else{
					Console.WriteLine("\nUsername or Password is Incorrect");
					Console.ReadLine();
					Console.Clear();
					Main();
				}
				Console.ReadKey(false);
				
				
				
		}
		
		public static void Info()
		{
			
			DateTime now = DateTime.Now;
            Console.WriteLine(now);
            
            Console.WriteLine("\n\t\t   Welcome\n");
            Console.WriteLine("\tEscuela de Brigida Montessori Inc.\n\n");
            
			string choice;
					
			Console.WriteLine("\n\n");		
			Console.WriteLine("[1] About");
			Console.WriteLine("[2] Students");
			Console.WriteLine("[3] Teachers");
			Console.WriteLine("[4] School Policies");
			Console.WriteLine("[5] Student Life");
			Console.WriteLine("[6] Safety and Privacy");
			Console.WriteLine("[7] Edit");
			Console.WriteLine("[8] Logout");
			Console.WriteLine("[9] Exit");
				choice = Console.ReadLine();
				if (choice == "1" || choice == "About" || choice == "about"){
				Console.Clear();
				About();
			}else if (choice == "2" || choice == "Student" || choice == "students"){
				Console.Clear();
				Students();
			}else if (choice == "3" || choice == "Teachers" || choice == "teachers"){
				Console.Clear();
				Teachers();
				}else if (choice == "4"){
					Console.Clear();
					Policies();
				}else if (choice == "5"){
					Console.Clear();
					StudentLife();
				}else if (choice == "6"){
					Console.Clear();
					SafetyPrivacy();
				}else if(choice == "7"){
					Console.Clear();
					EditP();
			}else if (choice == "8" || choice == "logout" || choice == "Logout"){
					Console.Clear();
					Main();
			}else if (choice == "exit" || choice == "9" || choice == "Exit"){
					Console.ReadLine();
					Console.Clear();
					Environment.Exit(0);
			}else{
				Console.WriteLine("Invalid Command");
					Console.ReadLine();
					Console.Clear();
					Info();
				
		}
				Console.ReadKey(false);			
	}
		
		public static void About()
		{
			DateTime now = DateTime.Now;
            Console.WriteLine(now);
            
            Console.WriteLine("\n\t\t   Welcome\n");
            Console.WriteLine("\tEscuela de Brigida Montessori Inc.\n\n\n");
            
			string line;
			string choice;
			Console.WriteLine("[1] Mission Vision");
			Console.WriteLine("[2] Contact Information");
			Console.WriteLine("[3] Address");
			Console.WriteLine("[4] Uniform");
			Console.WriteLine("[5] Edit");
			Console.WriteLine("[6] Return");
			Console.WriteLine("[7] Exit");
			choice = Console.ReadLine();
			if (choice == "1"){
				Console.Clear();
			try 
				{
					//Change directory by going to the folder till the end as follows
					StreamReader sr = new StreamReader(@"MS.txt");
					line =sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					About();
			}else if (choice == "2"){
				Console.Clear();
			try 
				{
					//Change directory by going to the folder till the end as follows
					StreamReader sr = new StreamReader(@"Contact");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception )
						{
						Console.WriteLine("Information Unavailable"/*"Exception: " + e.Message*/);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					About();
			}else if (choice == "3"){
				Console.Clear();
			try 
				{
					//Change directory by going to the folder till the end as follows
					StreamReader sr = new StreamReader(@"Address");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception )
						{
						Console.WriteLine("Information Unavailable"/*"Exception: " + e.Message*/);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					About();
			}else if (choice == "4"){
				Console.Clear();
			try 
				{
					//Change directory by going to the folder till the end as follows
					StreamReader sr = new StreamReader(@"Uniform.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					About();
			}else if (choice == "5"){
				Console.Clear();
				Edit();
			}else if (choice == "6"){
				Console.Clear();
				Info();
			}else if (choice == "7"){
				Environment.Exit(0);
			}else{
				Console.WriteLine("Invalid Command");
				Console.ReadKey();
				Console.Clear();
				About();
			}
		
		}
		
		public static void Policies()
		{
		string line;
		string linea;
				try 
				{
					StreamReader sr = new StreamReader(@"Policy");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Information Unavailable" + e.Message);
						}
   					finally 
						{
   						
						}
					try 
				{
					StreamReader ar = new StreamReader(@"Offenses.txt");
					linea = ar.ReadLine();
					
					while (linea != null) 
						{
						Console.WriteLine(linea);
						linea = ar.ReadLine();
						}
						ar.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Information Unavailable" + e.Message);
						}
   					finally 
						{
   						
						}   					
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					Info();
		}
		
		public static void StudentLife()
		{
			string line;
				try 
				{
					StreamReader sr = new StreamReader(@"StudentLife.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					Info();
		}
		
		public static void SafetyPrivacy()
		{
		string line;
				try 
				{
					StreamReader sr = new StreamReader(@"SafetyPrivacy.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}	
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					Info();
		}
	
		public static void Students()
		{
			DateTime now = DateTime.Now;
            Console.WriteLine(now);
            
            Console.WriteLine("\n\t\t   Welcome\n");
            Console.WriteLine("\tEscuela de Brigida Montessori Inc.\n\n\n");
            
			string line;
			string option;
        	Console.WriteLine("[1] Academic Calendar");
        	Console.WriteLine("[2] Subjects per Grade");
        	Console.WriteLine("[3] Return");
        	Console.WriteLine("[4] Exit");
        	option = Console.ReadLine();
        	if (option == "1"){
        		Console.Clear();
				try 
				{
					//Change directory by going to the folder till the end as follows
					StreamReader sr = new StreamReader(@"Calendar.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally
						{
   						
						}
   					
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					Students();
        	}else if(option == "2"){
        		Console.Clear();
        		try 
				{
					//Change directory by going to the folder till the end as follows
					StreamReader sr = new StreamReader(@"Subjects.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					Students();
        	}else if (option == "3"){
        		Console.Clear();
        		Info();
        	}else if (option == "4"){
        		Environment.Exit(0);
        	}else{
        		Console.WriteLine("Invalid Command");
        		Console.ReadKey();
        		Console.Clear();
        		Students();
        	}
       		 
		}

		
		public static void Teachers()
		{
            string num;
            Console.WriteLine("Teachers and Professor Basic Info.");
            Console.WriteLine("[1] Grade 7 Adviser");
            Console.WriteLine("[2] Grade 8 Adviser");
            Console.WriteLine("[3] Grade 9 Adviser");
            Console.WriteLine("[4] Grade 10 Adviser");
            Console.WriteLine("[5] Edit ");
            Console.WriteLine("[6] Return ");
            Console.WriteLine("[7] Exit");

            num = Console.ReadLine();
            

            switch (num)
            {
            	case "1":
                    Console.Clear();
                    TeacherA();
                    break;
                case "2":
                    Console.Clear();
                    TeacherB();
                    break;
                case "3":
                    Console.Clear();
                    TeacherC();
                    break;
                case "4":
                    Console.Clear();
                    TeacherD();
                    break;                 
                case "5":
                    Console.Clear();
                    CodetoFile(); 
                    break;
                case "6": 
                    Console.Clear();
                    Info();
                    break;
                case "7":
              	    Console.Clear();
                   	Environment.Exit(0);
                   	break;
                
                default:
              	    Console.WriteLine("Invalid Command");
              	    Console.ReadKey();
                    Console.Clear();
              	    Teachers();
                    break;


            }
		}
        public static void TeacherA()
            {
				string line;
				try 
				{
					StreamReader sr = new StreamReader(@"1");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					
				string day;
                Console.WriteLine("Schedule of Prof");
                Console.WriteLine(" [1] -   MONDAY");
                Console.WriteLine(" [2] -   TUESDAY");
                Console.WriteLine(" [3] -   WEDNESDAY");
                Console.WriteLine(" [4] -   THURSDAY");
                Console.WriteLine(" [5] -   FRIDAY");
                Console.WriteLine(" [6] -   Return"); 
                Console.WriteLine(" [7] -   Exit");
                Console.WriteLine("Input Number:");
                day = Console.ReadLine();
    
                if (day == "1"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Monday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey(false);
   					Console.Clear();
   					TeacherA();
                }else if (day == "2"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Tuesday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherA();
                }else if (day == "3"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Wednesday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherA();
                }else if (day == "4"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Thursday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherA();
                }else if (day == "5"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Friday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherA();
                }else if (day == "6"){
                	Console.Clear();
                	Teachers();
                }else if (day == "7"){
                	Environment.Exit(0);
                }else{
                	Console.WriteLine("Invalid Command");
                	Console.ReadKey();
                	Console.Clear();
                	TeacherA();
                }
            }
        public static void TeacherB()
            {
                string line;
				try 
				{
					StreamReader sr = new StreamReader(@"2");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					
				string day;
                Console.WriteLine("Schedule of Prof");
                Console.WriteLine(" [1] -   MONDAY");
                Console.WriteLine(" [2] -   TUESDAY");
                Console.WriteLine(" [3] -   WEDNESDAY");
                Console.WriteLine(" [4] -   THURSDAY");
                Console.WriteLine(" [5] -   FRIDAY");
                Console.WriteLine(" [6] -   Return"); 
                Console.WriteLine(" [7] -   Exit");
                Console.WriteLine("Input Number:");
                day = Console.ReadLine();
    
                if (day == "1"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Monday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherB();
                }else if (day == "2"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Tuesday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherB();
                }else if (day == "3"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Wednesday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherB();
                }else if (day == "4"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Thursday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherB();
                }else if (day == "5"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Friday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherB();
                }else if (day == "6"){
                	Console.Clear();
                	Teachers();
                }else if (day == "7"){
                	Environment.Exit(0);
                }else{
                	Console.WriteLine("Invalid Command");
                	Console.ReadKey();
                	Console.Clear();
                	TeacherB();
                }
 			}
        public static void TeacherC()
        {
        	string line;
				try 
				{
					StreamReader sr = new StreamReader(@"3");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					
				string day;
                Console.WriteLine("Schedule of Prof");
                Console.WriteLine(" [1] -   MONDAY");
                Console.WriteLine(" [2] -   TUESDAY");
                Console.WriteLine(" [3] -   WEDNESDAY");
                Console.WriteLine(" [4] -   THURSDAY");
                Console.WriteLine(" [5] -   FRIDAY");
                Console.WriteLine(" [6] -   Return"); 
                Console.WriteLine(" [7] -   Exit");
                Console.WriteLine("Input Number:");
                day = Console.ReadLine();
    
                if (day == "1"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Monday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherC();
                }else if (day == "2"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Tuesday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherC();
                }else if (day == "3"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Wednesday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherC();
                }else if (day == "4"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Thursday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherC();
                }else if (day == "5"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Friday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherC();
                }else if (day == "6"){
                	Console.Clear();
                	Teachers();
                }else if (day == "7"){
                	Environment.Exit(0);
                }else{
                	Console.WriteLine("Invalid Command");
                	Console.ReadKey();
                	Console.Clear();
                	TeacherC();
                }
        }
        public static void TeacherD()
        {
        	string line;
				try 
				{
					StreamReader sr = new StreamReader(@"4");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					
				string day;
                Console.WriteLine("Schedule of Prof");
                Console.WriteLine(" [1] -   MONDAY");
                Console.WriteLine(" [2] -   TUESDAY");
                Console.WriteLine(" [3] -   WEDNESDAY");
                Console.WriteLine(" [4] -   THURSDAY");
                Console.WriteLine(" [5] -   FRIDAY");
                Console.WriteLine(" [6] -   Return"); 
                Console.WriteLine(" [7] -   Exit");
                Console.WriteLine("Input Number:");
                day = Console.ReadLine();
    
                if (day == "1"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Monday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherD();
                }else if (day == "2"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Tuesday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherD();
                }else if (day == "3"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Wednesday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherD();
                }else if (day == "4"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Thursday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherD();
                }else if (day == "5"){
                	Console.Clear();
                	
				try 
				{
					StreamReader sr = new StreamReader(@"Friday.txt");
					line = sr.ReadLine();
					
					while (line != null) 
						{
						Console.WriteLine(line);
						line = sr.ReadLine();
						}
						sr.Close();
						
				}
					catch(Exception e)
						{
						Console.WriteLine("Exception: " + e.Message);
						}
   					finally 
						{
   						
						}
   					Console.WriteLine("\nPress any key to Return");
   					Console.ReadKey();
   					Console.Clear();
   					TeacherD();
                }else if (day == "6"){
                	Console.Clear();
                	Teachers();
                }else if (day == "7"){
                	Environment.Exit(0);
                }else{
                	Console.WriteLine("Invalid Command");
                	Console.ReadKey();
                	Console.Clear();
                	TeacherD();
                }
        }
        
        public static void Edit()
        {
        		FileStream ostrm;
    			StreamWriter writer;
    			TextWriter oldOut = Console.Out;
    			string fileName, firstLine, secondLine, thirdLine, fourthLine, fifthLine;
    			Console.WriteLine("Select the Info you want to Edit\n");
            	Console.WriteLine("Address");
            	Console.WriteLine("Contact");
            	Console.WriteLine("Return");
            	Console.WriteLine("Exit");
    			Console.WriteLine("\nEnter Label:");
   				fileName = Console.ReadLine();
   				if (fileName == "Address" || fileName == "address"){
   					Console.Clear();
    			try
    				{
        				ostrm = new FileStream ("./" + fileName, FileMode.OpenOrCreate, FileAccess.Write);
       					writer = new StreamWriter (ostrm);
				    }
				catch (Exception e)
    				{
       					Console.WriteLine ("Cannot open Redirect.txt for writing");
        				Console.WriteLine (e.Message);
        				return;
    				}
   				
				
				Console.WriteLine("Enter School's New Address");
				
				Console.WriteLine("Enter School's Street and Number");
				firstLine = Console.ReadLine();
				Console.WriteLine("Enter School's Baranggay");
				secondLine = Console.ReadLine();
				Console.WriteLine("Enter School's Municipality");
				thirdLine = Console.ReadLine();
				Console.WriteLine("Enter School's Province");
				fourthLine = Console.ReadLine();
				Console.WriteLine("Enter School's Zipcode");
				fifthLine = Console.ReadLine();
    			
    	
    			Console.SetOut (writer);
    			Console.WriteLine ("Address: ");
    			Console.WriteLine (firstLine);
    			Console.WriteLine(secondLine);
    			Console.WriteLine(thirdLine);
    			Console.WriteLine(fourthLine);
    			Console.WriteLine(fifthLine);
    			
    			Console.SetOut (oldOut);
    			writer.Close();
    			ostrm.Close();
    			Console.WriteLine ("\nEditing Complete");
    			Console.ReadKey(false);
    			Console.Clear();
    			About();
   			}else if(fileName == "Contact" || fileName == "contact") {
   					Console.Clear();
   					
   					try
    				{
        				ostrm = new FileStream ("./" + fileName, FileMode.OpenOrCreate, FileAccess.Write);
       					writer = new StreamWriter (ostrm);
				    }
				catch (Exception e)
    				{
       					Console.WriteLine ("Cannot open Redirect.txt for writing");
        				Console.WriteLine (e.Message);
        				return;
    				}
   				
				
				Console.WriteLine("Enter New Contact Number");
    			firstLine = Console.ReadLine();
   				Console.WriteLine("Enter New Email Address");
    			secondLine = Console.ReadLine();
    			
    	
    			Console.SetOut (writer);
    			Console.WriteLine ("Contact Us");
    			Console.WriteLine ("Contact Number: "+firstLine);
    			Console.WriteLine ("Email Address: "+secondLine);
    			Console.SetOut (oldOut);
    			writer.Close();
    			ostrm.Close();
    			Console.WriteLine ("\nEditing Complete");
    			Console.ReadKey(false);
    			Console.Clear();
    			About();
   				}else if(fileName == "return"|| fileName == "Return"){
   					Console.Clear();
   					About();
   				}else if (fileName == "exit" || fileName == "Exit"){
   					Environment.Exit(0);
   				}else{
   					Console.WriteLine("Invalid Input");
   					Console.ReadKey();
   					Console.Clear();
   					Edit();
   				}
        }
            
        public static void CodetoFile ()
			{
    			FileStream ostrm;
    			StreamWriter writer;
    			TextWriter oldOut = Console.Out;
    			string fileName, firstLine, secondLine, thirdLine, fourthLine, fifthLine;
    			Console.WriteLine("Select the Teacher you want to edit\n");
    			Console.WriteLine("[1] Grade 7 Adviser");
            	Console.WriteLine("[2] Grade 8 Adviser");
            	Console.WriteLine("[3] Grade 9 Adviser");
            	Console.WriteLine("[4] Grade 10 Adviser");
    			Console.WriteLine("\nEnter Number:");
   				fileName = Console.ReadLine();
    			try
    				{
        				ostrm = new FileStream ("./" + fileName, FileMode.OpenOrCreate, FileAccess.Write);
       					writer = new StreamWriter (ostrm);
				    }
				catch (Exception e)
    				{
       					Console.WriteLine ("Unavailable");
        				Console.WriteLine (e.Message);
        				return;
    				}
				
				Console.WriteLine("Enter Name");
    			firstLine = Console.ReadLine();
   				Console.WriteLine("\nEnter Age");
    			secondLine = Console.ReadLine();
    			Console.WriteLine("\nEnter Sex");
    			thirdLine = Console.ReadLine();
    			Console.WriteLine("\nEnter Address");
    			fourthLine = Console.ReadLine();
    			Console.WriteLine("\nEnter Major");
    			fifthLine = Console.ReadLine();
    	
    			Console.SetOut (writer);
    			Console.WriteLine ("Name: "+firstLine);
    			Console.WriteLine ("Age: "+secondLine);
    			Console.WriteLine ("Sex: "+thirdLine);
    			Console.WriteLine ("Address: "+fourthLine);
    			Console.WriteLine ("Major: "+fifthLine);
    			Console.SetOut (oldOut);
    			writer.Close();
    			ostrm.Close();
    			Console.WriteLine ("\nEditing Complete");
    			Console.ReadKey(false);
    			Console.Clear();
    			Teachers();
    			
}
        public static void EditP()
        {
        	FileStream ostrm;
    			StreamWriter writer;
    			TextWriter oldOut = Console.Out;
    			string fileName, firstLine, secondLine, thirdLine, fourthLine, fifthLine;
    			Console.WriteLine("Type in Policy to edit\n");
    			//Console.WriteLine("Policy");
            
   				fileName = Console.ReadLine();
    			try
    				{
        				ostrm = new FileStream ("./" + fileName, FileMode.OpenOrCreate, FileAccess.Write);
       					writer = new StreamWriter (ostrm);
				    }
				catch (Exception e)
    				{
       					Console.WriteLine ("Unavailable");
        				Console.WriteLine (e.Message);
        				return;
    				}
				
				Console.WriteLine("1st Policy");
    			firstLine = Console.ReadLine();
   				Console.WriteLine("\n2nd Policy");
    			secondLine = Console.ReadLine();
    			Console.WriteLine("\n3rd Policy");
    			thirdLine = Console.ReadLine();
    			Console.WriteLine("\n4th Policy");
    			fourthLine = Console.ReadLine();
    			Console.WriteLine("\n5th Policy");
    			fifthLine = Console.ReadLine();
    	
    			Console.SetOut (writer);
    			Console.WriteLine ("a. "+firstLine);
    			Console.WriteLine ("b: "+secondLine);
    			Console.WriteLine ("c: "+thirdLine);
    			Console.WriteLine ("d: "+fourthLine);
    			Console.WriteLine ("e: "+fifthLine);
    			Console.SetOut (oldOut);
    			writer.Close();
    			ostrm.Close();
    			Console.WriteLine ("\nEditing Complete");
    			Console.ReadKey(false);
    			Console.Clear();
    			Policies();
        }

	}
}