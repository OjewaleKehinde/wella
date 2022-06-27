using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
           Animal[] animals = {new Dog(10," Tim", "male"), new Cat(15,"Tam", "female"), new Frog(80,"Agbaaa", "male"), new Kitten(20,"Rotimi", "female"), new Tomcat(40,"Amaechi", "male")};
        for(int i = 0; i<animals.Length; i++){
            Console.WriteLine("{0} {1} {2}", animals[i].name, animals[i].age,animals[i].sound());
        }
        }
    }

    class Animal{
    public int age;
    public string name;
    public string gender;

    public virtual string sound(){
        return "Animal makes a sound";
    }
}

class Dog:Animal{

    public Dog(int age, string name, string gender){
     this.age = age;
     this.name = name;
     this.gender = gender;
    }
    public override string sound(){
        return "Dog sounds";
    }
}

class Cat:Animal{

    public Cat(int age, string name, string gender){
     this.age = age;
     this.name = name;
     this.gender = gender;
    }
    public override string sound(){
     return "Cat sounds";
    }
}

class Frog:Animal{
    public Frog(int age, string name, string gender){
     this.age = age;
     this.name = name;
     this.gender = gender;
    }
    public override string sound(){
    return "Frog sounds";
    }
}

class Kitten:Animal{
    public Kitten(int age, string name, string gender){
     this.age = age;
     this.name = name;
     this.gender = gender;
    }
    public override string sound(){
    return "Kitten sounds";
    }
}

class Tomcat:Animal{
    public Tomcat(int age, string name, string gender){
     this.age = age;
     this.name = name;
     this.gender = gender;
    }
    public override string sound(){
    return "Tomcat sounds";
    }
}
}
