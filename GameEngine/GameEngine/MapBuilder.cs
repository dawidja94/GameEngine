using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Map - Builder
namespace GameEngine
{

    public class LoadMap
    {
        public string grass = "";
        public string trees = "";
        public string liquids = "";
        public string underworld = "";
        public string dungeon = "";
        public string jungle = "";
        
        

    }
    public abstract class MapBuilder
    {
        protected LoadMap map;
        public LoadMap GetMap()
        {
            return map;
        }
        public void CreateNewMapLoad()
        {
            map = new LoadMap();
        }
        public abstract void BuildGrass();
        public abstract void BuildTrees();
        public abstract void BuildLiquids();
        public abstract void BuildUnderworld();
        public abstract void BuildDungeon();
        public abstract void BuildJungle();

    }

    public class MainPlanet : MapBuilder
    {
        public override void BuildGrass()
        {
            map.grass = "green";
        }
        public override void BuildTrees()
        {
            map.trees = "evergreen";
        }
        public override void BuildLiquids()
        {
            map.liquids = "water";
        }
        public override void BuildDungeon()
        {
            map.dungeon = "skeletonDungeon";
        }
        public override void BuildUnderworld()
        {
            map.underworld = "lavaUnderworld";
        }
        public override void BuildJungle()
        {
            map.jungle = "swamps";
        }
    }
    public class    ForeignPlanet : MapBuilder
    {
        public override void BuildGrass()
        {
            map.grass = "weeds";
        }
        public override void BuildTrees()
        {
            map.trees = "deadTrees";
        }
        public override void BuildLiquids()
        {
            map.liquids = "ice";
        }
        public override void BuildDungeon()
        {
            map.dungeon = "YetiDungeon";
        }
        public override void BuildUnderworld()
        {
            map.underworld = "frozenUnderworld";
        }
        public override void BuildJungle()
        {
            map.jungle = "SnowJungle";
        }
    }
    public class MapCreator
    {
        private MapBuilder mapBuilder;
        public void SetMapBuilder (MapBuilder build)
        {
            mapBuilder = build;
        }
        public LoadMap GetMap()
        {
            return mapBuilder.GetMap();
        }

        public void CreateMap()
        {
            this.mapBuilder.BuildGrass();
            this.mapBuilder.BuildTrees();
            this.mapBuilder.BuildLiquids();
            this.mapBuilder.BuildDungeon();
            this.mapBuilder.BuildUnderworld();
            this.mapBuilder.BuildJungle();

        }
    }
}
