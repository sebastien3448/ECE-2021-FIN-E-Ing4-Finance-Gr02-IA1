
using System.Collections.Generic;
using GeneticSharp.Domain.Chromosomes;
using Sudoku.Core;
using Sudoku.GeneticAlgorithmSolver.GeneticSharp;

namespace Sudoku.GeneticAlgorithmSolver
{
    /// <summary>
    /// Each type of chromosome for solving a sudoku is simply required to output a list of candidate sudokus
    /// </summary>
    public interface ISudokuChromosome
    {
        IList<IList<IList<int>>> UnfilteredPermutations { get; }
        IList<IList<int>> AllPermutations { get; }
        IList<IList<IList<int>>> TargetRowsPermutations { get; }
        object ExtendedMask { get; }
        SudokuBoard TargetSudokuBoard { get; }
        int Length { get; }

        IChromosome CreateNew();
        IChromosome CreateNew();
        Gene GenerateGene(int geneIndex);
        Gene GenerateGene(int geneIndex);
        IList<IList<IList<int>>> GetRowsPermutations();
        IList<GeneticSharp.SudokuBoard> GetSudokus();
        IList<SudokuBoard> GetSudokus();
    }
}