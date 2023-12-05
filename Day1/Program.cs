var array = File.ReadAllText("C:\\day1_AdventOfCode.txt").Split('\n').ToList();
var total = 0;
var isText = "";

array.ForEach((line) =>
{
    foreach (var charater in line)
    {
        if (!char.IsDigit(charater)) continue;
        var isNumber = char.IsDigit(charater);
        if (isNumber)
        {
            isText = isText + charater;
        }
    }
    if (isText.Length > 2)
    {
        isText = isText[0] + isText[^1].ToString();
    }

    if (isText.Length < 2)
        isText = isText + isText;

    total = int.Parse(isText) + total;
    isText = "";
});

Console.WriteLine("Calibration is "+total);