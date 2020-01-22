namespace SimpleCalculator
{
    public interface ICalculate<T> where T : IOperator
    {
        T Operation(T input,T result);
    }
}
