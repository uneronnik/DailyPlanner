﻿
using dz24_06_21.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz24_06_21.Classes
{
    class Car : ICar
    {
        public enum EngineTypes
        {
            Gas,
            Diesel
        }
        public enum TransmissionTypes
        {
            Manual,
            Automatic
        }
        public enum BodyTypes
        {
            ThreeVolume,
            TwoVolume
        }
        public enum FuelTypes
        {
            Gas,
            Diesel
        }

        private EngineTypes _engineType;
        private TransmissionTypes _transmissionType;
        private BodyTypes _bodyType;
        private FuelTypes _fuelType;

        /// <summary>
        /// max speed in km/h
        /// </summary>
        private int _maxSpeed;

        public EngineTypes EngineType { get => _engineType; }
        public TransmissionTypes TransmissionType { get => _transmissionType; }
        public BodyTypes BodyType { get => _bodyType; }
        public FuelTypes FuelType { get => _fuelType; }
        public int MaxSpeed { get => _maxSpeed; }

        protected Car(EngineTypes engineType, TransmissionTypes transmissionType, BodyTypes bodyType, int maxSpeed)
        {
            _engineType = engineType;
            _fuelType = (FuelTypes)(int)engineType;
            _transmissionType = transmissionType;
            _bodyType = bodyType;
            _maxSpeed = maxSpeed;
        }
        protected Car()
        {

        }

        public void Show()
        {
            Console.WriteLine($"EngineType: {_engineType}");
            Console.WriteLine($"TransmissionType: {_transmissionType}");
            Console.WriteLine($"BodyType: { _bodyType}");
            Console.WriteLine($"FuelType: {_fuelType}");
        }
    }
}
