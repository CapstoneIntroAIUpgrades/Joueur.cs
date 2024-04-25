// The traditional 6x7 board with pieces.

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

/// <summary>
/// The traditional 6x7 board with pieces.
/// </summary>
namespace Joueur.cs.Games.ConnectFour
{
    /// <summary>
    /// The traditional 6x7 board with pieces.
    /// </summary>
    public class Game : BaseGame
    {
        /// <summary>
        /// The game version hash, used to compare if we are playing the same version on the server.
        /// </summary>
        new protected static string GameVersion = "ff3da34375459be10b77fd8f82b24d9880f0a100e48e2202812118bfcfd42e1e";

        #region Properties
        /// <summary>
        /// The number of tiles on the board along the y (vertical) axis.
        /// </summary>
        public int Cols { get; protected set; }

        /// <summary>
        /// List of all the players in the game.
        /// </summary>
        public IList<ConnectFour.Player> Players { get; protected set; }

        /// <summary>
        /// A string describing all of the information necessary to fully represent the game's state.
        /// </summary>
        public string RepString { get; protected set; }

        /// <summary>
        /// The number of cells on the board along the x (horizontal) axis.
        /// </summary>
        public int Rows { get; protected set; }

        /// <summary>
        /// A unique identifier for the game instance that is being played.
        /// </summary>
        public string Session { get; protected set; }


        // <<-- Creer-Merge: properties -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add additional properties(s) here. None of them will be tracked or updated by the server.
        // <<-- /Creer-Merge: properties -->>
        #endregion


        #region Methods
        /// <summary>
        /// Creates a new instance of Game. Used during game initialization, do not call directly.
        /// </summary>
        protected Game() : base()
        {
            this.Name = "ConnectFour";

            this.Players = new List<ConnectFour.Player>();
        }


        // <<-- Creer-Merge: methods -->> - Code you add between this comment and the end comment will be preserved between Creer re-runs.
        // you can add additional method(s) here.
        // <<-- /Creer-Merge: methods -->>
        #endregion
    }
}
