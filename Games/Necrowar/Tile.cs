// A Tile in the game that makes up the 2D map grid.

// DO NOT MODIFY THIS FILE
// Never try to directly create an instance of this class, or modify its member variables.
// Instead, you should only be reading its variables and calling its functions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// <<-- Creer-Merge: usings -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
// you can add additional using(s) here
// <<-- /Creer-Merge: usings -->>

namespace Joueur.cs.Games.Necrowar
{
    /// <summary>
    /// A Tile in the game that makes up the 2D map grid.
    /// </summary>
    public class Tile : Necrowar.GameObject
    {
        #region Properties
        /// <summary>
        /// The amount of corpses on this tile.
        /// </summary>
        public int Corpses { get; protected set; }

        /// <summary>
        /// Whether or not the tile is considered to be a gold mine or not.
        /// </summary>
        public bool IsGoldMine { get; protected set; }

        /// <summary>
        /// Whether or not the tile is considered to be the island gold mine or not.
        /// </summary>
        public bool IsIslandGoldMine { get; protected set; }

        /// <summary>
        /// Whether or not the tile is considered a path or not.
        /// </summary>
        public bool IsPath { get; protected set; }

        /// <summary>
        /// Whether or not the tile is considered a river or not.
        /// </summary>
        public bool IsRiver { get; protected set; }

        /// <summary>
        /// Whether or not the tile is considered a tower or not.
        /// </summary>
        public bool IsTower { get; protected set; }

        /// <summary>
        /// Whether or not the tile can be moved on by workers.
        /// </summary>
        public bool IsWall { get; protected set; }

        /// <summary>
        /// The amount of Ghouls on this tile at the moment.
        /// </summary>
        public int NumOfGhouls { get; protected set; }

        /// <summary>
        /// The amount of Hell Hounds on this tile at the moment.
        /// </summary>
        public int NumOfHounds { get; protected set; }

        /// <summary>
        /// The amount of animated zombies on this tile at the moment.
        /// </summary>
        public int NumOfZombies { get; protected set; }

        /// <summary>
        /// The Tile to the 'East' of this one (x+1, y). Null if out of bounds of the map.
        /// </summary>
        public Necrowar.Tile TileEast { get; protected set; }

        /// <summary>
        /// The Tile to the 'North' of this one (x, y-1). Null if out of bounds of the map.
        /// </summary>
        public Necrowar.Tile TileNorth { get; protected set; }

        /// <summary>
        /// The Tile to the 'South' of this one (x, y+1). Null if out of bounds of the map.
        /// </summary>
        public Necrowar.Tile TileSouth { get; protected set; }

        /// <summary>
        /// The Tile to the 'West' of this one (x-1, y). Null if out of bounds of the map.
        /// </summary>
        public Necrowar.Tile TileWest { get; protected set; }

        /// <summary>
        /// The Tower on this Tile if present, otherwise null.
        /// </summary>
        public Necrowar.Tower Tower { get; protected set; }

        /// <summary>
        /// The type of Tile this is ('normal', 'path', 'river', 'mine', 'castle', 'pathSpawn', or 'workerSpawn').
        /// </summary>
        public string Type { get; protected set; }

        /// <summary>
        /// The Unit on this Tile if present, otherwise null.
        /// </summary>
        public Necrowar.Unit Unit { get; protected set; }

        /// <summary>
        /// The x (horizontal) position of this Tile.
        /// </summary>
        public int X { get; protected set; }

        /// <summary>
        /// The y (vertical) position of this Tile.
        /// </summary>
        public int Y { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add additional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of Tile. Used during game initialization, do not call directly.
        /// </summary>
        protected Tile() : base()
        {
        }

        /// <summary>
        /// Resurrect the corpses on this tile into zombies.
        /// </summary>
        /// <param name="number">Number of zombies on the tile that are being resurrected.</param>
        /// <returns>True if Unit was created successfully, false otherwise.</returns>
        public bool Res(int number)
        {
            return this.RunOnServer<bool>("res", new Dictionary<string, object> {
                {"number", number}
            });
        }


        /// <summary>
        /// Gets the neighbors of this Tile
        /// </summary>
        /// <returns>The neighboring (adjacent) Tiles to this tile</returns>
        public List<Tile> GetNeighbors()
        {
            var list = new List<Tile>();

            if (this.TileNorth != null)
            {
                list.Add(this.TileNorth);
            }

            if (this.TileEast != null)
            {
                list.Add(this.TileEast);
            }

            if (this.TileSouth != null)
            {
                list.Add(this.TileSouth);
            }

            if (this.TileWest != null)
            {
                list.Add(this.TileWest);
            }

            return list;
        }

        /// <summary>
        /// Checks if a Tile is pathable to units
        /// </summary>
        /// <returns>True if pathable, false otherwise</returns>
        public bool IsPathable()
        {
            // <<-- Creer-Merge: is_pathable_builtin -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
            return false; // DEVELOPER ADD LOGIC HERE
            // <<-- /Creer-Merge: is_pathable_builtin -->>
        }

        /// <summary>
        /// Checks if this Tile has a specific neighboring Tile
        /// </summary>
        /// <param name="tile">Tile to check against</param>
        /// <returns>true if the tile is a neighbor of this Tile, false otherwise</returns>
        public bool HasNeighbor(Tile tile)
        {
            if (tile == null)
            {
                return false;
            }

            return this.TileNorth == tile || this.TileEast == tile || this.TileSouth == tile || this.TileWest == tile;
        }

        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add additional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}