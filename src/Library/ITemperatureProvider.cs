using System;

namespace Observer
{
    public interface ITemperatureProvider: IObservable
    {
        Temperature Current { get; }
    }
}