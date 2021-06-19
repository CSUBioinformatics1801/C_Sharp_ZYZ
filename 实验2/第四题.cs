using System;
using System.Collections.Generic;
namespace Test5_4
{
    public class Part : IEquatable<Part>
    {
        public string PartName { get; set; }
        public int PartId { get; set; }
        public int English_Score { get; set; }
        public int Math_Score { get; set; }
        public int Sum_Score { get; set; }
        public override string ToString()
        {
            return "ID: " + PartId + " Name: " + PartName + " English: " + English_Score + " Math: " + Math_Score + " Sum:" + Sum_Score;
        }
        public override bool Equals(object obj)
        {//check null
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {//rank by Hash
            return PartId;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }// Should also override == and != operators.
        // public int SortByNameAscending(string name1, string name2){
        //     return name1.CompareTo(name2);
        // }// Default comparer for Part type.
        // public int CompareTo(Part comparePart){
        //     // A null value means that this object is greater.
        //     if (comparePart == null)//in case the user forget the name
        //         return 1;
        //     else
        //         return this.Sum_Score.CompareTo(comparePart.Sum_Score);
        //         //sort bt Sum_Score
        // }
    }
    public class Compare_by_Sum_Score : IComparer<Part>
    {
        public int Compare(Part a, Part b)
        {// sort by Sum_Score
            return a.Sum_Score.CompareTo(b.Sum_Score);
        }
    }
    public class Example
    {
        public static void Main()
        {
            // Create a list of parts.
            List<Part> parts = new List<Part>();
            Console.WriteLine("Input Student's name-Student Id-English Score-Math Score like \"Bjor-1819-80-81\"");
            string temp_string = Console.ReadLine();
            while (temp_string != "")
            {
                string[] t_s_array = temp_string.Split('-');
                parts.Add(new Part() { PartName = t_s_array[0], PartId = int.Parse(t_s_array[1]), English_Score = int.Parse(t_s_array[2]), Math_Score = int.Parse(t_s_array[3]), Sum_Score = (int.Parse(t_s_array[2]) + int.Parse(t_s_array[3])) });
                temp_string = Console.ReadLine();
            }// Add parts to the list.
             // Write out the parts in the list. This will call the overridden ToString method
             // in the Part class.
            Console.WriteLine("Before Sort:");
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
            // Call Sort on the list. This will use the 
            // default comparer, which is the Compare method 
            // implemented on Part.
            parts.Sort(new Compare_by_Sum_Score());
            Console.WriteLine("Sorting by Sum_Socre...");
            Console.WriteLine("After Sort:");
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
            // Check the list for part #1734. This calls the IEquatable.Equals method
            // of the Part class, which checks the PartId for equality.
            // Console.WriteLine("\nContains(\"1734\"): {0}",
            // parts.Contains(new Part {PartId=1734, PartName="" }));

            // // Insert a new item at position 2.
            // Console.WriteLine("\nInsert(2, \"1834\")");
            // parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });

            // //Console.WriteLine();
            // foreach (Part aPart in parts)
            // {
            //     Console.WriteLine(aPart);
            // }

            // Console.WriteLine("\nParts[3]: {0}", parts[3]);

            // Console.WriteLine("\nRemove(\"1534\")");

            // // This will remove part 1534 even though the PartName is different,
            // // because the Equals method only checks PartId for equality.
            // parts.Remove(new Part(){PartId=1534, PartName="cogs"});

            // Console.WriteLine();
            // foreach (Part aPart in parts)
            // {
            //     Console.WriteLine(aPart);
            // }
            // Console.WriteLine("\nRemoveAt(3)");
            // // This will remove the part at index 3.
            // parts.RemoveAt(3);

            // Console.WriteLine();
            // foreach (Part aPart in parts)
            // {
            //     Console.WriteLine(aPart);
            // }
        }
    }
}
