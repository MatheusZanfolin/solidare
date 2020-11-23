using System;

namespace Solidare.Core.Architecture.Model
{
    public class Confirmation
    {
        public Donation Donation { get; private set; }

        public DateTime Date { get; private set; }

        public Administrator Administrator { get; private set; }
    }
}