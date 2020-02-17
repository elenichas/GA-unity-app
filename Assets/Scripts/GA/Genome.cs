using System;
using System.Collections;
using System.Collections.Generic;
 using UnityEngine;
using System.Linq;


/// <summary>
/// Summary description for Genome.
/// </summary>
public abstract class Genome : IComparable
	{
		public long Length;
		public int  CrossoverPoint;
		public int  MutationIndex;
		public float CurrentFitness = 0.0f;

		abstract public void Initialize();
		abstract public void Mutate(string Houseprog );
		abstract public Genome Crossover(Genome g);
		abstract public char GenerateGeneValue(string Houseprog );
		abstract public void SetCrossoverPoint(int crossoverPoint);
		abstract public float CalculateFitness();
		abstract public bool  CanReproduce(float fitness);
		abstract public bool  CanDie(float fitness);
		abstract public string ToString();
		abstract public void	CopyGeneInfo(Genome g);

		
		abstract public int CompareTo(object a);

	}
 
