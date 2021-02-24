using System;

namespace H2_Help_Lone
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbarian barbarian = new Barbarian();
            Knight knight = new Knight();
            Witch witch = new Witch();
            Wizard wizard = new Wizard();

            barbarian.Die();
            knight.Cleave();
            witch.Heal();
        }
    }
}
