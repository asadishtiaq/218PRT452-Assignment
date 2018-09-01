using Assignment.lib;
using System;
using System.Numerics;
using Xunit;

namespace Assignment.Test
{
    public class CalculateTest
    {
        [Fact]
        public void Gradient()
        {
            Vector2 vector = new Vector2(12, 24);
            Vector2 vector2 = new Vector2(22, 65);
            Calculate.CalculateGradient(vector,vector2);
        }
        [Fact]
        public void Distance()
        {
            Vector2 vector = new Vector2(12, 24);
            Vector2 vector2 = new Vector2(22, 65);
            Calculate.CalculateDistance(vector, vector2);
        }
        [Fact]
        public void Equation()
        {
            Vector2 vector = new Vector2(12, 24);
            Vector2 vector2 = new Vector2(22, 65);
            Calculate.CalculateEquation(vector, vector2);
        }
    }
}
