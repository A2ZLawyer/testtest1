using System;
namespace ooplesson4task1
{
    public class Buildings
    {
        private static uint _counter = 1;
        private uint _idBuilding;
        private float _height;
        private short _floor;
        private uint _flat;
        private uint _entrance;
        public void Add(float height, short floor, uint flat, uint entrance)
        {
            _idBuilding = CounterPlus(_counter);
            _height = height;
            _floor = floor;
            _flat = flat;
            _entrance = entrance;
        }
        public void Add(uint apartmentsOnTheFloor, short floor, uint entrance)
        {
            _idBuilding = _counter++;
            _floor = floor;
            _entrance = entrance;
            _flat = apartmentsOnTheFloor * (uint)_floor * _entrance;
            BuildingHeight(_floor);
        }
        public void BuildingHeight(short floor)
        {
            float basement = 1.3F;
            float attic = 3.9F;
            _floor = floor;
            _height = (floor * 2) + basement + attic;
        }
        public void Print()
        {
            Console.WriteLine($"Уникальный номер здания: {_idBuilding}; высота: {_height}; этажность: {_floor}; количество квартир: {_flat}; количества подъездов: {_entrance};");
        }
        public uint CounterPlus(uint counter)
        {
            return counter++;
        }
    }
}