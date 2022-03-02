using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
namespace ConsoleApp2
{
    internal class Program
    {
        public delegate int Del(int n,int n1);
        static void Main(string[] args)

        {
           /* BillManagement manager = new BillManagement();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
               
            }*/
            
            //GenericIndexer();

            // BooksList();

            //Reflection();
            //ReflectionOnMemberInfo();
            //ReflectionDemo();
            //SampleAttribute.CallGetAtribute();



            //ScooterDictionary();
            // Empserialize();
            //Empdeserialize();


            //mycat.show();

            //ISerializble();

            //  Serialization_Deserialization();
            //JsonDeserilization();
            // JsonSerialization();
            //directoryinfo();
            //directory();
            //streamBinaryReader();
            //streamwriter();
            //streamreader();
            //Predicate();
            //ActionDelegate();
            //FuncDelegate();
            //Delegate();
            //SortingCollection();
            //IEnumerable();
            //CollectionInitializer();
            //Stack();
            // Queue();
            //Dictionary1();
            //Dictionary();
            //Collection();
            //GenericListCollection();
            //CustomException();
            //Exception();
            //StaticMethod();
            //Indexer();
            //GenericDemo();
            //InterfaceProperties();
            //MultipleInheritance();
            //Entertainment();
            // Abstract();
            //AnonymousType();
            //Hierarchial();
            // SingleInheritance();
            // MultilevelInheritance();

        }

        private static void GenericIndexer()
        {
            Indexer<Book> index = new Indexer<Book>();
            index[0] = new Book { Bookcode = 123, Title = "Wise and otherwise", Author = "SudhaMurthy", Price = 400 };
            index[1] = new Book { Bookcode = 124, Title = "Three thousand stitches", Author = "SudhaMurthy", Price = 600 };
            index[2] = new Book { Bookcode = 125, Title = "Wings of fire", Author = "Abdul Kalam", Price = 435 };
            index[3] = new Book { Bookcode = 126, Title = "Gitanjali", Author = "Rabindranath Tagore", Price = 500 };
            index[4] = new Book { Bookcode = 127, Title = "The teacher I never met", Author = "Eshan Sharma", Price = 450 };
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"bookcode:{index[i].Bookcode}\ttitle:{index[i].Title}\t" +
                    $"author:{index[i].Author}\tprice:{index[i].Price}");
            }
        }

        private static void BooksList()

        {
            List<Book1> books = new List<Book1>();
            books.Add(new Book1
            {
                Id = 123,
                Title = "Wings of fire",
                Author = "Abdul kalam",
                Price = 500,
                Publish = new Publisher { Id = 101, Name = "xyz", Address = "Hyd" }
            });
            books.Add(new Book1
            {
                Id = 124,
                Title = "Wise and Otherwise",
                Author = "sudha murthy",
                Price = 400,
                Publish = new Publisher { Id = 102, Name = "abc", Address = "Chennai" }
            });
            books.Add(new Book1
            {
                Id = 125,
                Title = "Three thousand stitches",
                Author = "sudha murthy",
                Price = 500,
                Publish = new Publisher { Id = 103, Name = "pqr", Address = "Banglore" }
            });
            
            foreach (var b in books)
            {
                Console.WriteLine($"book details\nbookid:{b.Id}\ttitle:{b.Title}\tauthor:{b.Author}\t" +
                    $"price:{b.Price}\npublisher details:\nid:{b.Publish.Id}\tname:{b.Publish.Name}" +
                    $"\taddress:{b.Publish.Address}");
                
                Console.WriteLine();
            }
        }

        private static void ReflectionDemo()
        {
            Console.WriteLine("\nReflection.MemberInfo");
            // Gets the Type and MemberInfo.
            Type myType = Type.GetType("System.IO.File");

            
            MemberInfo[] myMemberInfoArray = myType.GetMembers();
            
            // Gets and displays the DeclaringType method.
            Console.WriteLine("\nThere are {0} members in {1}.",
                myMemberInfoArray.Length, myType.FullName);
            //Console.WriteLine("{0}.", myType.FullName);
            if (myType.IsPublic)
            {
                Console.WriteLine("{0} is public.", myType.FullName);
            }
        }
        private static void ReflectionOnMemberInfo()
        {
            // This code displays information about the GetValue method of FieldInfo.
            Console.WriteLine("Reflection.MethodInfo");
            // Gets and displays the Type.
            Type myType = Type.GetType("System.Reflection.FieldInfo");
            // Specifies the member for which we need type information.
            MethodInfo myMethodInfo = myType.GetMethod("GetValue");
            Console.WriteLine(myType.FullName + "." + myMethodInfo.Name);
            // Gets and displays the MemberType property.
            MemberTypes myMemberTypes = myMethodInfo.MemberType;
            if (MemberTypes.Constructor == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type All");
            }
            else if (MemberTypes.Custom == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Custom");
            }
            else if (MemberTypes.Event == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Event");
            }
            else if (MemberTypes.Field == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Field");
            }
            else if (MemberTypes.Method == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Method");
            }
            else if (MemberTypes.Property == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type Property");
            }
            else if (MemberTypes.TypeInfo == myMemberTypes)
            {
                Console.WriteLine("MemberType is of type TypeInfo");
            }
            
        }

        private static void Reflection()
        {
            int i = 10;
            double d = 234.56;
            string s = "hello";
            Type type = i.GetType();
            Type t = d.GetType();
            Type st = s.GetType();
            Console.WriteLine(type);
            Console.WriteLine(t);
            Console.WriteLine(st);
            Assembly info = typeof(int).Assembly;
            Console.WriteLine(info);
            Assembly sinfo = typeof(string).Assembly;
            Console.WriteLine(sinfo);
            Assembly cat = typeof(Cat).Assembly;
            Console.WriteLine(cat);
        }

        private static void ScooterDictionary()
        {
            Dictionary<int, Scooter> sc = new Dictionary<int, Scooter>();
            sc.Add(1, new Scooter { Regno = "10236", Model = "OLA series S", Price = 97706 });
            sc.Add(2, new Scooter { Regno = "23439", Model = "Honda activa 6G", Price = 70857 });
            sc.Add(3, new Scooter { Regno = "108735", Model = "Suzuki Access 125", Price = 74980 });
            sc.Add(4, new Scooter { Regno = "12345", Model = "TVS jupiter", Price = 69638 });
            foreach (var s in sc.Values)
            {
                Console.WriteLine($"reg.no:{s.Regno},model:{s.Model},price:{s.Price}");
                ;
            }
        }

        private static void Empserialize()
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee { EmpId=101,Name="Shekar",Joindate=DateTime.Parse("2021-04-12"),Department="HR",Salary=43234.00},
                new Employee { EmpId=102,Name="vijaya",Joindate=DateTime.Parse("2020-09-14"),Department="Finance",Salary=45674.00}

            };
            string jsonString = JsonSerializer.Serialize(emp);
            string fileName = "emp.json";

            Console.WriteLine(jsonString);
            Console.WriteLine();
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));
        }

        private static void Empdeserialize()
        {
            string fileName = "emp.json";
            string jsonString = File.ReadAllText(fileName);


            List<Employee> emp = new List<Employee>();
            emp = JsonSerializer.Deserialize<List<Employee>>(jsonString);
           
            foreach (var x in emp)
            {
                
                Console.WriteLine($"empid: {x.EmpId}");
                Console.WriteLine($"name: {x.Name}");
                Console.WriteLine($"dept: {x.Department}");
                Console.WriteLine($"salary: {x.Salary}");
                Console.WriteLine($"joindate: {x.Joindate}");
               
            }
        }

        private static void ISerializble()
        {
            string filename = "datastuff.txt";
            IFormatter formatter = new BinaryFormatter();
            SerializeItem(filename, formatter);
            DeserializeItem(filename, formatter);
            Console.WriteLine("done");
        }

        public static void SerializeItem(string filename, IFormatter formatter)
        {
            MyItemType t=new MyItemType();
            t.MyValue = "Hello world";
            FileStream s = new FileStream(filename, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();
        }
        public static void DeserializeItem(string filename,IFormatter formatter)
        {
            FileStream s = new FileStream(filename, FileMode.Open);
            MyItemType t=(MyItemType)formatter.Deserialize(s);
            Console.WriteLine(t.MyValue);
        }

        private static void Serialization_Deserialization()
        {
            Cat mycat = new Cat();
            mycat.Name = "lucifer";
            mycat.Description = "italian";
            mycat.Age = 1;
            mycat.show();
            Stream strm = File.Open("data.xml", FileMode.Create);
            BinaryFormatter bfrm = new BinaryFormatter();
            bfrm.Serialize(strm, mycat);
            strm.Close();
            mycat = null;
            deserilalise(out mycat, out strm, out bfrm);
        }

        private static void deserilalise(out Cat mycat, out Stream strm, out BinaryFormatter bfrm)
        {
            strm = File.Open("data.xml", FileMode.Open);
            bfrm = new BinaryFormatter();
            mycat = (Cat)bfrm.Deserialize(strm);
            strm.Close();
            Console.WriteLine("After deserialization");
            mycat.show();
        }

        private static void JsonDeserilization()
        {

            string fileName = "Weather Forecast.json";
            string jsonString = File.ReadAllText(fileName);

            
            WeatherForecast weatherforecast = new WeatherForecast();
            weatherforecast = JsonSerializer.Deserialize<WeatherForecast>(jsonString);

            Console.WriteLine($"Date: {weatherforecast.Date}");
            Console.WriteLine($"TemperatureCelsius: {weatherforecast. TemperatureCelsius}");
            Console.WriteLine($"Summary: {weatherforecast.Summary}");
        }
        private static void JsonSerialization()
        {
            var weatherForecast = new WeatherForecast
            {

                Date = DateTime.Parse("2022-02-24"),
                TemperatureCelsius = 31,
                Summary = "Hot"
            };

            string jsonString = JsonSerializer.Serialize(weatherForecast);
            string fileName = "Weather Forecast.json";

            Console.WriteLine(jsonString);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(File.ReadAllText(fileName));
        }

        private static void directoryinfo()
        {
            DirectoryInfo dif = new DirectoryInfo(@"D:\Hello");
            try
            {
                if (dif.Exists)
                {
                    Console.WriteLine("The directory path is Existing");
                }
                dif.Create();
                Console.WriteLine("Directory created successfully");
                //dif.Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void directory()
        {
            string sourcefile = @"D:\current";
            string destfile = @"D:\archive";
            try
            {
                var textfile = Directory.EnumerateFiles(sourcefile, "*.txt");
                foreach (string file in textfile)
                {
                    string filename = file.Substring(sourcefile.Length + 1);
                    Directory.Move(file, Path.Combine(destfile, filename));

                }
                Console.WriteLine("text files are moved form sourcefile to destfile");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void streamBinaryReader()
        {
            string filename = "hello.txt";
            if (File.Exists(filename))
            {
                using (var stream = File.Open(filename, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        Console.WriteLine(reader.ReadSingle());
                        Console.WriteLine(reader.ReadString());
                        Console.WriteLine(reader.ReadInt32());
                        Console.WriteLine(reader.ReadBoolean());
                    }
                }
            }
        }

        private static void streamwriter()
        {
            DirectoryInfo[] dirinfo = new DirectoryInfo(@"C:\").GetDirectories();
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in dirinfo)
                {
                    sw.WriteLine(dir.Name);

                }
            }
            Console.WriteLine("text file has been created");
            

        }
        private static void streamreader()
        {
            string path = "D:\\streamReader.txt";
            string line;
            try
            {
                StreamReader sr = new StreamReader(path);
                while ((line=sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                sr.Close();
                sr.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Predicate()
        {
            Predicate<int> evencheck = EvenOrNot;
            bool  res = EvenOrNot(10);
            if (res)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
        }

        private static void ActionDelegate()
        {
            Action<string> action = (msg) => Console.WriteLine("This is an action" + msg);
            action("Delegate");
            Action<int, int> divide = (n, n1) => Console.WriteLine("{0}/{1}={2}", n, n1, n / n1);
            divide(6, 2);
        }
        public static bool EvenOrNot(int n)
        {
            if(n%2==0)
            {
                return true;
            }
            return false;
        }
        private static void FuncDelegate()
        {
            //lambda expression (=>)
            Func<int, int, int> product = (n, n1) => n * n1;
            Func<int, int, int> sum = AddNumbers;
            Func<int, int> square = n => n * n;
            Func<int> sendno = () => 60;
            Func<int, double, double> func = (n, n1) => n * (n - n1);

            Console.WriteLine("product={0}", product(26, 28));
            Console.WriteLine("Sum={0}", sum(5, 6));
            Console.WriteLine(square(5));
            Console.WriteLine(sendno());
            Console.WriteLine(func(10, 10.91));
        }

        private static void SortingCollection()
        {
            var cars = new List<Car>
            {
                {new Car{Name="car1",Color="blue",Speed=20} },
                {new Car{Name="car2",Color="red",Speed=50} },
                {new Car{Name="car3",Color="green",Speed=10}},
                {new Car{Name="car4",Color="blue",Speed=50}},
            { new Car { Name="car5",Color="blue",Speed=30}},
            { new Car { Name="car6",Color ="red",Speed=60}},
            { new Car { Name="car7",Color="green",Speed=50}}
            };
            cars.Sort();
            foreach (Car thisCar in cars)
            {
                Console.Write(thisCar.Color.PadRight(5) + " ");
                Console.Write(thisCar.Speed.ToString() + " ");
                Console.Write(thisCar.Name);
                Console.WriteLine();
            }
        }

        private static void IEnumerable()
        {
            FormattedAddress addresses = new FormattedAddress()
            {
                { "John","Doc", "123 Street" , "Topeka" ,"KS" ,"00000"},
                { "Jane", "Smith", "456 Street", "Topeka", "KS", "00000"}
            };

            Console.WriteLine("Address Entries:");

            foreach (string addressEntry in addresses)
            {
                Console.WriteLine("\r\n" + addressEntry);
            }
        }

        private static void Delegate()
        {
            //Del d = AddNumbers;
            Del d = new Del(AddNumbers);
            int sum = d(25, 80);
            Console.WriteLine("sum={0}", sum);
            //delegate multicasting
            d += ProductOfNumbers;

            int prod = d(10, 11);
            Console.WriteLine("prod={0}", prod);
            d += Difference;
            int diff = d(10, 5);
            d -= Difference;
            Console.WriteLine(d(35, 12));
        }

        public static int Difference(int n,int n1)
        {
            return n - n1;
        }
        public static int AddNumbers(int n,int n1)
        {
            return n + n1;
        }
        public static int ProductOfNumbers(int n,int n1)
        {
            return n * n1;
        }
        private static void CollectionInitializer()
        {
            List<string> list = new List<string> { "Ravali", "Akhia", "sharanya" };
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            List<int> list2 = new List<int> { 1, 2, 3, 4, 5, 6, };
            foreach (int item in list2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            List<Cat> cats = new List<Cat>
            {
                new Cat { Name = "Cherry", Description = "Persian", Age = 1 },
                new Cat { Name = "Mustcateer", Description = "italian", Age = 2 }

            };
            foreach (var cat in cats)
            {
                Console.WriteLine("{0} {1} {2}", cat.Name,
                    cat.Description, cat.Age);
            }
        }
        private static void Stack()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Banglore");
            stack.Push("Hyderabad");
            stack.Push("Delhi");
            foreach (var city in stack)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("The popped item is:{0}", stack.Pop());
            foreach (var city in stack)
            {
                Console.WriteLine(city);
            }
        }

        private static void Queue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Shalini");
            queue.Enqueue("Archana");
            queue.Enqueue("Venkat");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        private static void Dictionary1()
        {
            Dictionary<int, Customer> custdic = new Dictionary<int, Customer>();
            custdic.Add(1, new Customer
            {
                Customerid = 125,
                Name = "Sharath",
                Email = "sharath12@gmail,com",
                Phone = "1423587692"
            });
            custdic.Add(2, new Customer
            {
                Customerid = 126,
                Name = "Shirish",
                Email = "shirish13@gmail,com",
                Phone = "8795487692"
            });
            custdic[1].Name = "Amrutha";
            foreach (var cust in custdic.Values)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    cust.Customerid, cust.Name, cust.Email
                    , cust.Phone);
            }
        }

        private static void Dictionary()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Hyderabad");
            dic.Add(2, "Banglore");
            dic.Add(3, "Chennai");
            dic.Add(4, "Pune");
            foreach (var city in dic)
            {
                Console.WriteLine("{0}.{1}",
                    city.Key, city.Value);
            }
        }

        private static void Collection()
        {
            var cs = new List<Customer>();
            cs.Add(new Customer/*(123,"shravani","shravs12@gmail.com","1234567896")*/
            {
                Customerid = 123,
                Name = "shravani",
                Email = "shravs12@gmail.com",
                Phone = "1234567896"
            });
            cs.Add(new Customer/*(124,"seeta","seeta99@gmail.com","8934547896")*/
            {
                Customerid = 124,
                Name = "seeta",
                Email = "seeta99@gmail.com",
                Phone = "8934547896"
            });
            foreach (var c in cs)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}"
                    , c.Customerid, c.Name, c.Email, c.Phone);

            }
        }

        private static void GenericListCollection()
        {
            string[] names = new[] { "Ganesh", "Sarah", "Indu" };
            var f = new List<string>();
            f.Add("Anshu");
            f.Add("Bhanu");
            f.Add("Raghu");
            f.Add("Anwitha");
            f.AddRange(names);
            f.Remove("Bhanu");
            foreach (var friend in f)
            {
                Console.WriteLine(friend);
            }
            string[] fr = new string[20];

            f.CopyTo(fr);
            Console.WriteLine("Now friends are in fr array");
            foreach (var friend in fr)
            {
                Console.WriteLine(friend);
            }
        }

        private static void CustomException()
        {
            Console.WriteLine("enter any number below 100");
            int n = int.Parse(Console.ReadLine());
            try
            {
                if (n > 99)
                {
                    //throw keyword is used to raise new exceptions
                    throw new MyCustomException("Please enter a number below 100 only");
                }
            }
            catch (MyCustomException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine(n);
            }
        }

        private static void Exception()
        {
            int x = 0;
            try
            {
                int y = 100 / x;
                Console.WriteLine(y);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(x);
            }
        }

        private static void StaticMethod()
        {
            double d = -90.12;
            Console.WriteLine("absolute value={0}", Math.Abs(d));
            Console.WriteLine("Rounded value={0}", Math.Round(Math.Abs(d)));
            Console.WriteLine("FLoor value={0}", Math.Floor(d));
            Console.WriteLine("Square root ={0}", Math.Sqrt(Math.Abs(Math.Round(d))));
        }

        private static void Indexer()
        {
            var index = new Indexer<string>();
            index[0] = "Hello";
            index[1] = "Anshu";
            Console.WriteLine("{0}\t{1}", index[0], index[1]);
            var ind = new Indexer<int>();
            ind[0] = 32;
            ind[1] = 64;
            Console.WriteLine("{0}\t{1}", ind[0], ind[1]);
        }

        private static void GenericDemo()
        {
            Generic<string> gstring = new Generic<string>();
            gstring.f = "Hello";
            Generic<int> gint = new Generic<int>();
            gint.f = 32;
            Console.WriteLine("generic string={0}\tgeneric int={1}"
                , gstring.f, gint.f);
            Generic<Book> book = new Generic<Book>();
            book.f = new Book();
            book.f.Bookcode = 123;
            book.f.Title = "Wise and Otherwise";
            book.f.Author = "SudhaMurthy";
            book.f.Price = 250;
            Console.WriteLine($"bookcode={book.f.Bookcode}\ttitle={book.f.Title}" +
                $"\tauthor={book.f.Author}\tprice={book.f.Price}");
        }

        private static void InterfaceProperties()
        {
            Student st = new Student();
            st.Name = "Raghu";
            Console.WriteLine("name={0}\tno.of.students={1}", st.Name, st.Count);
            Student st1 = new Student();
            st1.Name = "Shekar";
            Console.WriteLine("name={0}\tno.of.students={1}", st1.Name, st1.Count);
        }

        private static void MultipleInheritance()
        {
            Activity ac = new Activity();
            ac.Doit();
            ac.Makeit();
            Console.WriteLine("rate of interest={0}", ac.ROI());
        }

        private static void Entertainment()
        {
            Movie m = new Movie("thriller", "Lavanya Tripathi",
                            "Arjun suravaram", "Santhosh", "Rajkumar");
            Console.WriteLine("Accessed from 'Movie' class object");
            Console.WriteLine("Movie type={0}\nfavourite actor={1}" +
                "\nMovie name={2}\nDirector={3}\nProducer={4}", m.Type,
                m.FavActor, m.MovieName, m.Director, m.Producer);
            Console.WriteLine("Accessed from 'Live shows' class obj:");
            LiveShows ls = new LiveShows("Comedy", "chandan Prabhakar",
                "The kapil sharma show", "Kapil sharma");
            Console.WriteLine("ShowType={0}\nfavourite show cast={1}" +
                "\nshow name={2}\nHost name={3}", ls.Type,
                ls.FavActor, ls.ShowName, ls.Host);

        }

        private static void Abstract()
        {
            Console.WriteLine("Abstract class:");
            AXIS axis = new AXIS();
            Console.WriteLine("ROI of axis bank={0}", axis.ROI());
            SBI sb = new SBI();
            Console.WriteLine("ROI of SBI ={0}", sb.ROI());
        }

        private static void AnonymousType()
        {
            var a = new { Name = "Raghu", City = "Hyd" };
            Console.WriteLine("Anonymous type:");
            Console.WriteLine("Name={0},City={1}", a.Name, a.City);
            var anonymArray = new[] { new { Name = "Shekar", City =
                "Banglore" } ,new { Name="Rakesh",City="Warangal"} };
            Console.WriteLine("anonymous array:");
            foreach (var A in anonymArray)
            {
                Console.WriteLine("Name={0},City={1}", A.Name, A.City);
            }
        }

        private static void Hierarchial()
        {
            Wholeseller ws = new Wholeseller(222, "ABC whole seller", "abc123@gmail.com", "1234567899", "FMCG");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", ws.Customerid, ws.Name, ws.Email, ws.Phone, ws.nicheBusiness);
            Distributor ds = new Distributor(444, "Super Distributors", "superdistributor@gmail.com", "1234356798", "South");
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", ds.Customerid, ds.Name, ds.Email, ds.Phone, ds.Area);
        }

        private static void MultilevelInheritance()
        {
          Novel n=new Novel();
            n.Bookcode = 123;
            n.Title = "The Pilgrim's Process";
            n.Author = "John Bunyan";
            Console.WriteLine("book code={0},title={1},author={2}",n.Bookcode,n.Title,n.Author);
        }

        private static void SingleInheritance()
        {
            ShortStories st = new ShortStories();
            st.Title = "Stories at sleep time";
            st.Bookcode = 5777;
            st.Author = "Rudali";
            st.Price = 500;
            st.no_of_stories = 12;
            Console.WriteLine("Book code={0}, title={1},author={2},price={3},no.of.stories={4}", st.Bookcode, st.Title, st.Author, st.Price, st.no_of_stories);
        }
    }
}
