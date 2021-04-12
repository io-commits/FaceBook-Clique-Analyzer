using FacebookWrapper.ObjectModel;
using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Facade
{
    public class FacadeCliqueAnalysis
    {
        public Dictionary<int, Clique> Cliques { get; private set; }
        private CliqueGenerator m_Generator;
        private CliqueAnalyzer m_Analyzer;
        public FacadeCliqueAnalysis()
        {
            Cliques = new Dictionary<int, Clique>();
            m_Generator = new CliqueGenerator();
            m_Analyzer = new CliqueAnalyzer();
        }

        public void Construct(User i_LoggedInUser)
        {
            Cliques = m_Generator.BuildCliques(i_LoggedInUser);
        }

        public void DetermineCliqueMainInterest(Clique currentClique)
        {
            m_Analyzer.DetermineCliqueMainInterest(currentClique);
        }

        public Dictionary<int,Clique> FilterCliques(ICliqueFilter i_Filter)
        {
            Dictionary<int, Clique> filteredCliques = new Dictionary<int, Clique>();

            foreach(var clique in Cliques)
            {
                if (i_Filter.Filter(clique.Value))
                {
                    filteredCliques.Add(clique.Key,clique.Value);
                }
            }
            
            return filteredCliques;
        }

        public Dictionary<int, Clique> GetFemaleCliquesOnly()
        {
            Dictionary<int, Clique> femaleOnlyDict = new Dictionary<int, Clique>();
            foreach(var clique in Cliques)
            {
                Clique current = clique.Value.ShallowCopy();
                
                foreach(var iterator in clique.Value)
                {
                    current.AddMemberNoFieldUpdate(iterator);
                }
                femaleOnlyDict.Add(current.ID, current);
            }

            return femaleOnlyDict;
        }
    }
}
