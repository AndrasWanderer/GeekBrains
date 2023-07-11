int[] array = {1,2,22,2,1,3};

Dictionary<int, int> numbs = new Dictionary<int, int>();

for (int i = 0; i < array.Length; i++){
    //bool isLine = false;

    if (numbs.ContainsKey(array[i])){
        numbs[array[i]] = numbs[array[i]] +1;
    }else{
        numbs.Add(array[i], 1);
    }
}

foreach(var lines in numbs)
{
    Console.WriteLine($"число: {lines.Key}  количество: {lines.Value}");
}