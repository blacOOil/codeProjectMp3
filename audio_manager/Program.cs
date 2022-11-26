using System;
class Program {
    public static char starter; //ในตัวเต็มจะรับ ค่าจากการ login
    static void Main()
    {
        starting(); 
        if(starter != '+'){ // เมื่อ login ได้ จะเริ้มทำงานส่วนนี้
            explained();//ส่านนี้จะอธิบายให้ userว่าต้องกดอะไรบ้าง
             inputCommand(); //รับค่าให้ ีuser พิม 1 2 3 แล้วเก็บในลิสด์ 

        }
    }
    static void starting(){
        char Command;
        Console.Clear();
        Console.WriteLine(":::::::::::::::::::");
        Console.WriteLine("   Please input any letter to start");
        Console.WriteLine(":::::::::::::::::::");
        starter = char.Parse(Console.ReadLine());

    }
    static void inputCommand(){
        char Command;
        if(starter != '+'){
              Console.WriteLine("Please Input play order: ");

        Command = char.Parse(Console.ReadLine());
        CircularLinkedList<char> Playlist = new CircularLinkedList<char>();
        while(Command == '1'|| Command == '2'|| Command == '3'){ // ยังไม่เสด

        }

    }

}
static void explained(){
    Console.Clear();
    Console.WriteLine("-press number 1 - 3 to making a track- ");
    Console.WriteLine("Then Press 'p' to play");
}
}