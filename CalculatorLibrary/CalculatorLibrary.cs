namespace CalculatorLibrary;

using System.Diagnostics;
using Newtonsoft.Json;
public class Calculator
{
    JsonWriter writer;
    public int calculationsAmount = 0;
    public Calculator() 
    {
        StreamWriter logFile = File.CreateText("calculator.log");
        Trace.AutoFlush = true;
        writer = new JsonTextWriter(logFile);
        writer.Formatting = Formatting.Indented;
        writer.WriteStartObject();
        writer.WritePropertyName("Operations");
        writer.WriteStartArray();
    }
    public double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN;

        writer.WriteStartObject();
        writer.WritePropertyName("Operand1");
        writer.WriteValue(num1);
        writer.WritePropertyName("Operand2");
        writer.WriteValue(num2);
        writer.WritePropertyName("Operation");
        // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = num1 + num2;
                writer.WriteValue("Add");
                break;
            case "s":
                result = num1 - num2;
                writer.WriteValue("Subtract");
                break;
            case "m":
                result = num1 * num2;
                writer.WriteValue("Multiply");
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                writer.WriteValue("Divide");
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        AddOperation(calculationsAmount);
        writer.WritePropertyName("Result");
        writer.WriteValue(result);
        writer.WriteEndObject();

        return result;
    }
    public int AddOperation(int numberOfCalculations)
    {
        return numberOfCalculations++;
    }
    public void Finish()
    {
        writer.WriteEndArray();
        writer.WritePropertyName("CalculationsAmount");
        writer.WriteValue(calculationsAmount);
        writer.WriteEndObject();
        writer.Close();
    }
}