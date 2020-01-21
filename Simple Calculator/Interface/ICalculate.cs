namespace SimpleCalculator
{
    public interface ICalculate<T>
    {
        T Operation(T input,T result);
    }
}
