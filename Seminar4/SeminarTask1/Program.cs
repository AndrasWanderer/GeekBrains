//задача про палиндром

bool Ispalindrome(int number)
{
    bool result = false;
  
    int revNumber = 0;
    int tempSourceNumber = number;
    while(tempSourceNumber != 0)
    {
        int temp = number % 10;

        revNumber = (revNumber * 10) + temp;

        number = number / 10;
    }

    if(revNumber == number)
    {
        result = true;
    }

    return result;
}

Console.WriteLine(Ispalindrome(13431));