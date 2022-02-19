using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ExpressionLibrary
{
    /// <summary>
    /// Class describe algebraic expression
    /// </summary>
    public class Expression
    {
        private const string _regex = @"([0-9]+(\s)[+*/-](\s))*[0-9]+";
        private string _expression;
        private string prioritySign = @"[\/\*]";

        /// <summary>
        /// Created object for class Expression
        /// </summary>
        /// <param name="expression"></param>
        public Expression(string expression)
        {
            _expression = expression;
            CheckingAnExpressionCnComplianceFormat();
        }

        /// <summary>
        /// Checking an expression on compliance format
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void CheckingAnExpressionCnComplianceFormat()
        {
            if (!Regex.IsMatch(_expression, _regex))
            {
                throw new Exception("The expression should consist of number or signs: +,-,*,/");
            }
        }

        /// <summary>
        /// Calling the calculation method depending on the presence of priority signs
        /// </summary>
        /// <returns>Result for expression</returns>
        public double FindingResults()
        {
            List<string> expressionParts = new List<string>();
            expressionParts.AddRange(_expression.Split(' '));

            if (Regex.IsMatch(_expression, prioritySign))
            {
                return ResultWithPrioritySign(expressionParts);
            }
            else
            {
                return ResultWithoutPrioritySign(expressionParts);
            }
        }

        /// <summary>
        /// Count result of expression with priority sign
        /// </summary>
        /// <param name="expressionParts"></param>
        /// <returns>Result for expression with priority sign</returns>
        private double ResultWithPrioritySign(List<string> expressionParts)
        {
            for (int i = 1; i < expressionParts.Count; i += 2)
            {
                if (expressionParts[i] == "*" || expressionParts[i] == "/")
                {
                    switch (expressionParts[i])
                    {
                        case "*":

                            expressionParts[i - 1] = Convert.ToString(Convert.ToDouble(expressionParts[i - 1]) * Convert.ToDouble(expressionParts[i + 1]));
                            expressionParts.RemoveAt(i);
                            expressionParts.RemoveAt(i);
                            i -= 2;
                            break;
                        case "/":
                            expressionParts[i - 1] = Convert.ToString(Convert.ToDouble(expressionParts[i - 1]) / Convert.ToDouble(expressionParts[i + 1]));
                            expressionParts.RemoveAt(i);
                            expressionParts.RemoveAt(i);
                            i -= 2;
                            break;
                    }
                }
            }
            return ResultWithoutPrioritySign(expressionParts);
        }

        /// <summary>
        /// Count result of expression without priority sign
        /// </summary>
        /// <param name="expressionParts"></param>
        /// <returns>Result for expression without priority sign</returns>
        private double ResultWithoutPrioritySign(List<string> expressionParts)
        {
            double result = Convert.ToDouble(expressionParts[0]);

            for (int i = 2; i < expressionParts.Count; i += 2)
            {
                switch (expressionParts[i - 1])
                {
                    case "+":
                        result += Convert.ToDouble(expressionParts[i]);
                        break;
                    case "-":
                        result -= Convert.ToDouble(expressionParts[i]);
                        break;
                }
            }

            return result;
        }
    }
}