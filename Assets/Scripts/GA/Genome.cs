using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Genome.
/// </summary>
public abstract class Genome : IComparable
	{
    public long Lengthother;
    public int CrossoverPoint;
    public int MutationIndex;
    public double CurrentFitness = 0.0;
    abstract public void Initialize();
    abstract public void Mutate( );
    abstract public Genome Crossover(Genome g);
    abstract public Genome OrderedCrossover(Genome g);
    abstract public char GenerateGeneValue( );
    abstract public double CalculateFitness();
    abstract public bool CanReproduce(float fitness);
    abstract public void SetCrossoverPoint(int crossoverPoint);
    abstract public bool CanDie(float fitness);
    abstract public int ToMyStringOnlyF();
    abstract public string ToMyStringOnlyG();
    abstract public void CopyGeneInfo(Genome g);
    abstract public int CompareTo(object a);


}

