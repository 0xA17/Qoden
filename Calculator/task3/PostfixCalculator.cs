using System;
using System.Collections.Generic;

namespace QodenTasks.task3;

public class PostfixCalculator
{
    public void PerformCalculation(String input)
    {
        if (String.IsNullOrWhiteSpace(input))
            return;

        Int32 result = Calculate(input);
        Console.WriteLine(result.ToString());
    }

    private Int32 Calculate(String input)
    {
        String[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Stack<Int32> stack = new Stack<Int32>();

        foreach (String token in tokens)
        {
            if (Int32.TryParse(token, out Int32 number))
            {
                stack.Push(number);
            }
            else if (IsOperator(token))
            {
                if (stack.Count < 2)
                    throw new ArgumentException("Invalid expression");

                Int32 operand2 = stack.Pop();
                Int32 operand1 = stack.Pop();
                Int32 result = PerformOperation(token, operand1, operand2);

                stack.Push(result);
            }
            else
            {
                throw new ArgumentException("Invalid token: " + token);
            }
        }

        if (stack.Count != 1)
            throw new ArgumentException("Invalid expression");

        return stack.Pop();
    }

    private Boolean IsOperator(String token)
    {
        return token == "+" || token == "-" || token == "*" || token == "/";
    }

    private Int32 PerformOperation(String op, Int32 a, Int32 b)
    {
        switch (op)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                return a / b;
            default:
                throw new ArgumentException("Invalid operator: " + op);
        }
    }
}