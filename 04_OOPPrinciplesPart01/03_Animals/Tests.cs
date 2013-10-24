using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tests
{
     static void Main(string[] args)
    {
         // Cats
         List<Cat> catsCollection = new List<Cat>();
         catsCollection.Add(new Cat(3, "Pissy", Sex.female));
         catsCollection.Add(new Cat(1, "Missi", Sex.male));
         catsCollection.Add(new Cat(5, "Mausi", Sex.female));
         catsCollection.Add(new Cat(4, "Bausi", Sex.male));
         catsCollection.Add(new Cat(9, "Daisy", Sex.female));

         var avarageAgeCats = catsCollection.Average((x) => x.Age);
         Console.WriteLine("Avarage age of all cats is {0}\n", avarageAgeCats);

         // Frogs
         List<Frog> frogsCollection = new List<Frog>();
         frogsCollection.Add(new Frog(5, "Pissy", Sex.female));
         frogsCollection.Add(new Frog(1, "Missi", Sex.male));
         frogsCollection.Add(new Frog(8, "Mausi", Sex.female));
         frogsCollection.Add(new Frog(1, "Bausi", Sex.male));
         frogsCollection.Add(new Frog(3, "Daisy", Sex.female));

         var avarageAgeFrogs = frogsCollection.Average((x) => x.Age);
         Console.WriteLine("Avarage age of all frogs is {0}\n", avarageAgeFrogs);

         // Dogs
         List<Dog> dogsCollection = new List<Dog>();
         dogsCollection.Add(new Dog(3, "Pissy", Sex.female));
         dogsCollection.Add(new Dog(1, "Missi", Sex.male));
         dogsCollection.Add(new Dog(6, "Mausi", Sex.female));
         dogsCollection.Add(new Dog(7, "Bausi", Sex.male));
         dogsCollection.Add(new Dog(12, "Daisy", Sex.female));

         var avarageAgeDogs = dogsCollection.Average((x) => x.Age);
         Console.WriteLine("Avarage age of all dogs is {0}\n", avarageAgeDogs);

         // Kittens
         List<Kitten> kittensCollection = new List<Kitten>();
         kittensCollection.Add(new Kitten(3, "Pissy"));
         kittensCollection.Add(new Kitten(8, "Missi"));
         kittensCollection.Add(new Kitten(5, "Mausi"));
         kittensCollection.Add(new Kitten(4, "Bausi"));
         kittensCollection.Add(new Kitten(9, "Daisy"));

         var avarageAgeKittens = kittensCollection.Average((x) => x.Age);
         Console.WriteLine("Avarage age of all kittens is {0}\n", avarageAgeKittens);

         // Kittens
         List<Tomcat> tomcatsCollection = new List<Tomcat>();
         tomcatsCollection.Add(new Tomcat(5, "Pissy"));
         tomcatsCollection.Add(new Tomcat(6, "Missi"));
         tomcatsCollection.Add(new Tomcat(2, "Mausi"));
         tomcatsCollection.Add(new Tomcat(11, "Bausi"));
         tomcatsCollection.Add(new Tomcat(9, "Daisy"));

         var avarageAgeTomcats = tomcatsCollection.Average((x) => x.Age);
         Console.WriteLine("Avarage age of all Tomcats is {0}\n", avarageAgeTomcats);
    }
}