using System;
namespace ProjectsOfClassesAndObjects
    {
     class Robot
    {
       public string name;
       public string speciallity;
       public int ICNum;

        /*      Default Constructure
                   Robot(){
                   name=NULL;
                   speciallity=NULL
                   ICnum=0;
               }
        */
        
        public Robot(string name,string speciallity, int IC)
        {
            this.name = name;
            this.speciallity = speciallity;
            ICNum = IC;
        }
        
        public void selfIntrodution()
        {
            Console.WriteLine("Take salam, my name is "+name+" and my IC Number is "+ICNum);
            Console.WriteLine("I can "+speciallity);
            Console.WriteLine("---------------------------------------------------------------------------");
        }
    }
}
