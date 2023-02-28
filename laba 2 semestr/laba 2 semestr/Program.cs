


 //                                     Завдання 1
/*
List<int> nums = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13
};

for (int i = 1; i < nums.Count; i+=2)
{
    int a = nums[i];
        nums[i] = nums[i - 1];
        nums[i - 1] = a;
        Console.Write(nums[i-1]+" "+nums[i]+" ");
        
        if(nums.Count%2!=0&&nums.Count-1==i+1)
            Console.Write(nums.Last());
   
}*/
 
//                                       Завдання 2
 
/*using Newtonsoft.Json;

Dictionary<int, int> slovnyk = new Dictionary<int, int>()
{
    [1] = 20,
    [2] = 10,
    [6] = 30,
    [4] = 50,
    [5] = 40
};

var max = 0;
var count = 0;
var countElem = 0;
var countElem1 = 0;
int[] value = new int[5];

foreach (var num in slovnyk)
{
    value[count] = num.Value;
    count++;
}
for (int i = 0; i < value.Length; i++)
{
    if (value[i]>max)
    {
        max = value[i];
        countElem = i+1;
    }
}
Console.WriteLine(countElem+" max element = "+max);
var min = max;
for (int i = 0; i < value.Length; i++)
{
    if (value[i]<min)
    {
        min = value[i];
        countElem1 = i+1;
    }
}
Console.WriteLine(countElem1+" min element = "+min);
slovnyk.Remove(countElem);
slovnyk.Remove(countElem1);


var file = "C:\\Users\\Влад\\RiderProjects\\laba 2 semestr\\laba 2 semestr\\1.txt";

var sorted = slovnyk.OrderBy(x=>x.Key);
Dictionary<int, int> slovnyk2 = new Dictionary<int, int>();

foreach (var s in sorted)
{
    slovnyk2.Add(s.Key,s.Value);
}
string json1 = JsonConvert.SerializeObject(slovnyk2);
StreamWriter sw1 = new StreamWriter(file);
sw1.WriteLine(json1);
sw1.Close();*/
 
//                                         Завдання 3
 
List<int> list = new List<int>()
{
    2, -7, 4, 6, -1, 3, - 4,5
};
var countPositive = list.Count(x => x > 0);
var sumNepar = list.Where(x => x % 2 != 0).Sum();
Console.WriteLine("кількість додатних елементів = "+countPositive);

Console.WriteLine("сума непарних елементів = "+sumNepar);
                                