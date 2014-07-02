/***************************************************************
 * Description: This class implements the acutal chess board UI.
 * This class handles drawing and events handling for the board
 ***************************************************************/
using System;
using System.Collections;
using System.Windows.Forms;
using ChessLibrary;
using System.Collections.Generic;

namespace Chess
{
	/// <summary>
	/// Summary description for ChessBoard.
	/// </summary>
	public class GameUI
	{
		private ArrayList Squars;	// Picture control array for storing the place holders
		public Images ChessImages;	// Contains reference of chess images
		private string ResourceFolder;		// Contain the locaiton of resource folder
		private int LogCounter;			// Stores the entries in the log
       
		public Game ChessGame;		    // Backend chess game engine
        public bool WhoWins=true;		
		public string	SelectedSquar;	// Contains name of the selected squar
        public string LastSelectedSquar;// The last selected squar
		public ChessMain ParentForm;	// Reference of the parent form 
		public bool ShowMoveHelp;		// Show possible move by colors
		public bool IsRunning;			// Return true when the game is running
		public bool IsOver;				// Set to true when the game is over
        public bool ShowComputerThinkingProgres = true;    // Set wether to show the progress of the computer thinking
        public bool LastMoveByClick;    // Stores true if the last move was made by mouse click (instead of drag and drop)
        public Stack<double> result = new Stack<double>();
        public Stack<double> resultBlack = new Stack<double>();
		public GameUI(ChessMain form)
		{
			this.ParentForm = form;	// get and store reference of parent form

			// Load all the chess images in a list
			ChessImages = new Images();

            #if DEBUG
			    ResourceFolder = "..\\..\\Resources\\";
            #else
                ResourceFolder = "Resources\\";
            #endif
			ChessImages.LoadImages(ResourceFolder);
		
			BuildBoard();
          
			

			// Initialize variables
			ShowMoveHelp = true; // 
		}


        private double InitCounter( Board CurentBoard)

        {   ArrayList countBlack = CurentBoard.GetSideCell(Side.SideType.Black); // current position black pieces count            
            ArrayList countWhite = CurentBoard.GetSideCell(Side.SideType.White);  // current position black pieces count
            double SumRealValueAllPiecesBlack = 0; // 
            double SumRealValueAllPiecesWhite = 0;
             for (int i = 0; i < countBlack.Count; i++)
            {
                ArrayList moves = ChessGame.GetLegalMoves(ChessGame.Board[countBlack[i].ToString()]);
                switch (ChessGame.Board[countBlack[i].ToString()].piece.Type)
                {
                   
                    case Piece.PieceType.Pawn:	// Pawn object
                        SumRealValueAllPiecesBlack += (moves.Count+1)*0.5;
                        break;
                    case Piece.PieceType.Knight:	// Knight object
                        SumRealValueAllPiecesBlack += (moves.Count + 1)*0.375;
                        break;
                    case Piece.PieceType.Rook:	// Rook piece
                        if (moves.Count < 2)
                        {
                            SumRealValueAllPiecesBlack += (moves.Count + 2) ;
                        }
                        else
                        {
                            SumRealValueAllPiecesBlack += (moves.Count + 1) * 0.36;
                        }

                        break;
                    case Piece.PieceType.Bishop:	// Bishop piece
                        SumRealValueAllPiecesBlack += (moves.Count + 1)*0.231;
                        break;
                    case Piece.PieceType.Queen:	// Queen piece
                        if (moves.Count < 2)
                        {
                            SumRealValueAllPiecesBlack += (moves.Count + 2);
                        }
                        else
                        {
                            SumRealValueAllPiecesBlack += (moves.Count + 1) * 0.33;
                        }
                        break;
                    case Piece.PieceType.King:	// king piece
                      SumRealValueAllPiecesBlack += (moves.Count + 1)*1.25;
                        break;
             }           
               
            }
            for (int j = 0; j < countWhite.Count; j++)
            {
                ArrayList moves = ChessGame.GetLegalMoves(ChessGame.Board[countWhite[j].ToString()]);
                switch (ChessGame.Board[countWhite[j].ToString()].piece.Type)
                {
                    case Piece.PieceType.Pawn:	// Pawn object
                        SumRealValueAllPiecesWhite += (moves.Count + 1) * 0.5;
                        break;
                    case Piece.PieceType.Knight:	// Knight object
                        SumRealValueAllPiecesWhite += (moves.Count + 1) * 0.375;
                        break;
                    case Piece.PieceType.Rook:	// Rook piece
                        if (moves.Count < 2)
                        {
                            SumRealValueAllPiecesWhite += (moves.Count + 2);
                        }
                        else
                        {
                            SumRealValueAllPiecesWhite += (moves.Count + 1) * 0.36;
                        }

                        break;
                    case Piece.PieceType.Bishop:	// Bishop piece
                        SumRealValueAllPiecesWhite += (moves.Count + 1) * 0.231;
                        break;
                    case Piece.PieceType.Queen:	// Queen piece
                        if (moves.Count < 2)
                        {
                            SumRealValueAllPiecesWhite += (moves.Count + 2);
                        }
                        else
                        {
                            SumRealValueAllPiecesWhite += (moves.Count + 1) * 0.33;
                        }
                        break;
                    case Piece.PieceType.King:	// king piece
                        SumRealValueAllPiecesWhite += (moves.Count + 1) * 1.25;
                        break;
                }

            }
            SumRealValueAllPiecesWhite = Math.Round(SumRealValueAllPiecesWhite,3);
            SumRealValueAllPiecesBlack = Math.Round(SumRealValueAllPiecesBlack,3);
            ParentForm.BlackPlayerTime.Text =SumRealValueAllPiecesWhite.ToString();
            ParentForm.label5.Text = SumRealValueAllPiecesBlack.ToString();
            ParentForm.label4.Text = (SumRealValueAllPiecesWhite - SumRealValueAllPiecesBlack).ToString();

            ListViewItem newitem;
            newitem = new ListViewItem( (SumRealValueAllPiecesWhite - SumRealValueAllPiecesBlack).ToString());
            ParentForm.listView1.Items.Add(newitem);
     
                return (SumRealValueAllPiecesWhite - SumRealValueAllPiecesBlack);

         


           
        }
        private double InitCounterBlack(Board CurentBoard)
        {
            ArrayList countBlack = CurentBoard.GetSideCell(Side.SideType.Black); // current position black pieces count            
            ArrayList countWhite = CurentBoard.GetSideCell(Side.SideType.White);  // current position black pieces count
            double SumRealValueAllPiecesBlack = 0; // 
            double SumRealValueAllPiecesWhite = 0;
            for (int i = 0; i < countBlack.Count; i++)
            {
                ArrayList moves = ChessGame.GetLegalMoves(ChessGame.Board[countBlack[i].ToString()]);
                switch (ChessGame.Board[countBlack[i].ToString()].piece.Type)
                {

                    case Piece.PieceType.Pawn:	// Pawn object
                        SumRealValueAllPiecesBlack += (moves.Count + 1) * 0.5;
                        break;
                    case Piece.PieceType.Knight:	// Knight object
                        SumRealValueAllPiecesBlack += (moves.Count + 1) * 0.375;
                        break;
                    case Piece.PieceType.Rook:	// Rook piece
                        if (moves.Count < 2)
                        {
                            SumRealValueAllPiecesBlack += (moves.Count + 2);
                        }
                        else
                        {
                            SumRealValueAllPiecesBlack += (moves.Count + 1) * 0.36;
                        }

                        break;
                    case Piece.PieceType.Bishop:	// Bishop piece
                        SumRealValueAllPiecesBlack += (moves.Count + 1) * 0.231;
                        break;
                    case Piece.PieceType.Queen:	// Queen piece
                        if (moves.Count < 2)
                        {
                            SumRealValueAllPiecesBlack += (moves.Count + 2);
                        }
                        else
                        {
                            SumRealValueAllPiecesBlack += (moves.Count + 1) * 0.33;
                        }
                        break;
                    case Piece.PieceType.King:	// king piece
                        SumRealValueAllPiecesBlack += (moves.Count + 1) * 1.25;
                        break;
                }

            }
            for (int j = 0; j < countWhite.Count; j++)
            {
                ArrayList moves = ChessGame.GetLegalMoves(ChessGame.Board[countWhite[j].ToString()]);
                switch (ChessGame.Board[countWhite[j].ToString()].piece.Type)
                {
                    case Piece.PieceType.Pawn:	// Pawn object
                        SumRealValueAllPiecesWhite += (moves.Count + 1) * 0.5;
                        break;
                    case Piece.PieceType.Knight:	// Knight object
                        SumRealValueAllPiecesWhite += (moves.Count + 1) * 0.375;
                        break;
                    case Piece.PieceType.Rook:	// Rook piece
                        if (moves.Count < 2)
                        {
                            SumRealValueAllPiecesWhite += (moves.Count + 2);
                        }
                        else
                        {
                            SumRealValueAllPiecesWhite += (moves.Count + 1) * 0.36;
                        }

                        break;
                    case Piece.PieceType.Bishop:	// Bishop piece
                        SumRealValueAllPiecesWhite += (moves.Count + 1) * 0.231;
                        break;
                    case Piece.PieceType.Queen:	// Queen piece
                        if (moves.Count < 2)
                        {
                            SumRealValueAllPiecesWhite += (moves.Count + 2);
                        }
                        else
                        {
                            SumRealValueAllPiecesWhite += (moves.Count + 1) * 0.33;
                        }
                        break;
                    case Piece.PieceType.King:	// king piece
                        SumRealValueAllPiecesWhite += (moves.Count + 1) * 1.25;
                        break;
                }

            }
            SumRealValueAllPiecesWhite = Math.Round(SumRealValueAllPiecesWhite, 3);
            SumRealValueAllPiecesBlack = Math.Round(SumRealValueAllPiecesBlack, 3);
           
           
            return ( SumRealValueAllPiecesBlack-SumRealValueAllPiecesWhite);





        }


      
		public void BuildBoard()
		{
			Squars = new ArrayList();	// Initialize place holder pictures

			// Now dynamically draw all the chess pieces place holder images
			for (int row=1; row<=8; row++)		// repeat for every row in the chess board
				for (int col=1; col<=8; col++)	// repeat for every column in the chess board row
				{
					Squar ChessSquar = new Squar(row, col, this);
					ChessSquar.SetBackgroundSquar(ChessImages);	// Set the chess squar background
					Squars.Add(ChessSquar);
					ParentForm.Controls.Add(ChessSquar);
				}
           // 
		}


		// retunrs board squar for the given name
		private Squar GetBoardSquar(string strCellName)
		{
			 foreach (Squar ChessSquar in Squars)
			{
				if (ChessSquar.Name == strCellName)
					return ChessSquar;
			}
			return null;
		}

		// Redraw the visible board from the internal chess board
		public void RedrawBoard()
		{
             
			foreach (Squar ChessSquar in Squars)
			{
				if (ChessSquar.BackgroundImage==null) // background image doesn't exists
				{
					ChessSquar.SetBackgroundSquar(ChessImages);
				}

                if (ChessGame.Board[ChessSquar.Name] != null)	// Valid board squar
                {
                   
                    ChessSquar.DrawPiece(ChessImages.GetImageForPiece(ChessGame.Board[ChessSquar.Name].piece)); // draw the chess piece image
                   
                   
                }
				 if (ChessSquar.Name == SelectedSquar && ShowMoveHelp==true) // selected check box
				{
					ChessSquar.BackgroundImage = null;
					ChessSquar.BackColor = System.Drawing.Color.Thistle;
				}
			}
          

			// Check if need to show the possible legal moves for the current selected piece
			if (SelectedSquar != null && SelectedSquar != "" && ShowMoveHelp==true && ChessGame.Board[SelectedSquar].piece != null && !ChessGame.Board[SelectedSquar].piece.IsEmpty() &&  ChessGame.Board[SelectedSquar].piece.Side.type == ChessGame.GameTurn )
			{
				ArrayList moves=ChessGame.GetLegalMoves(ChessGame.Board[SelectedSquar]);	// Get all legal moves for the current selected item
			
				// Hightlight all the possible moves for the current player
				foreach (Cell cell in moves)
				{
					Squar sqr=GetBoardSquar(cell.ToString());	// get the board by cell position
					sqr.BackgroundImage = null;
                    // Show a semi-transparent, saddle color
                    sqr.BackColor = System.Drawing.Color.FromArgb(200, System.Drawing.Color.SaddleBrown);
                 
				}
			}
			SelectedSquar="";	// Reset the selected squar position
          
		}

	
		

		// Initialize the Chess player objects
		private void InitPlayers()
		{
           
			// Initialize other board objects
			
			// Set the time 
            ParentForm.BlackPlayerTime.Text = "";
           
            
           
		}
      
		// A move is made by the player
		public bool UserMove(string source, string dest)
		{
            bool success = true;
			int MoveResult=ChessGame.DoMove(source, dest);
            
			RedrawBoard();	// Refresh the board
            

			switch (MoveResult)
			{
				case 0:	// move was successfull;
					// check if the last move was promo move
					Move move=ChessGame.GetLastMove();	// get the last move 

					
				
					// If last move was a pawn promotion move, get the new selected piece from user
					if (move.IsPromoMove() && !ChessGame.ActivePlay.IsComputer())
						ChessGame.SetPromoPiece(GetPromoPiece(move.EndCell.piece.Side));	// Set the promo piece as selected by user
					
					// check for the check mate situation
					if (ChessGame.IsCheckMate(ChessGame.GameTurn))
					{
                        if (ChessGame.GameTurn.ToString() == "White")
                            this.WhoWins = false;
						IsOver=true;
						MessageBox.Show(ChessGame.GetPlayerBySide(ChessGame.GameTurn).Name + " is checkmate.", "Game Over",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        
                      
                        Result resultform = new Result(this);
                        resultform.Show();
                        ParentForm.Hide();
                       
                      
                        
                    
					}
					// check for the statemate situation
					if (ChessGame.IsStaleMate(ChessGame.GameTurn))
					{
						
						IsOver=true;
						MessageBox.Show(ChessGame.GetPlayerBySide(ChessGame.GameTurn).Name + " is stalmate.", "Game Over",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
					}
					LogUserMove(move.ToString());	// Log the user action
                   
					break;

				default:
                    success = false;
					break;
			}

            return success;
		}
       

		// Let user give the option of selecting promo piece
		public Piece GetPromoPiece(Side PlayerSide)
		{
			SelectPiece SelectPieceDlg = new SelectPiece();

			// Initialize the images to show on the form
			SelectPieceDlg.Piece1.Image = ChessImages.GetImageForPiece(new Piece(Piece.PieceType.Queen,PlayerSide));
			SelectPieceDlg.Piece2.Image = ChessImages.GetImageForPiece(new Piece(Piece.PieceType.Knight,PlayerSide));
			SelectPieceDlg.Piece3.Image = ChessImages.GetImageForPiece(new Piece(Piece.PieceType.Rook,PlayerSide));
			SelectPieceDlg.Piece4.Image = ChessImages.GetImageForPiece(new Piece(Piece.PieceType.Bishop,PlayerSide));
			
			SelectPieceDlg.ShowDialog(this.ParentForm);	// Show the promo select dialog

			// Now return back corresponding piece 
			switch (SelectPieceDlg.SelectedIndex)
			{
				case 1:
					return new Piece(Piece.PieceType.Queen,PlayerSide);
				case 2:
					return new Piece(Piece.PieceType.Knight,PlayerSide);
				case 3:
					return new Piece(Piece.PieceType.Rook,PlayerSide);
				case 4:
					return new Piece(Piece.PieceType.Bishop,PlayerSide);
			}
			return null;
		}

		// Display the user move in the history log
		public void LogUserMove(string movestring)
		{
            this.result.Push(InitCounter(ChessGame.Board));
            this.resultBlack.Push(InitCounterBlack(ChessGame.Board));
           
			LogCounter++;

             ListViewItem newItem;
             if (LogCounter % 2 == 0)	// even entry
             {
                 newItem = new ListViewItem(new string[] { LogCounter.ToString(), movestring }, -1);
                
           
                 newItem.ForeColor = System.Drawing.Color.Blue;
             }
             else
             {

                 newItem = new ListViewItem(new string[] { LogCounter.ToString(), movestring }, -1);
                 
                
             }

			ParentForm.lstHistory.Items.Add(newItem);
			ParentForm.lstHistory.Items[ParentForm.lstHistory.Items.Count-1].EnsureVisible();	// Scroll down
		
            // If the log has more than 16 items, reduce the width of the detail column to avoid 
            // horizontal scrollbar
            if (ParentForm.lstHistory.Items.Count > 16)
                ParentForm.lstHistory.Columns[1].Width = 90;
        }

		// Undo the last move
		public void UndoMove()
		{
			IsOver=false;				// Reset the is running variable
           
           
            // check if the last move was promo move
            Move move = ChessGame.GetLastMove();	// get the last move 

			if (ChessGame.UnDoMove())
			{
				LogUserMove("Undo Move");	// Log the user action

              
			}

			// If computer is playing do the double undo
			if (ChessGame.ActivePlay.IsComputer())
			{
                move = ChessGame.GetLastMove();	// get the last move 
				ChessGame.UnDoMove();

			}
            this.result.Pop();
            this.resultBlack.Pop();
			RedrawBoard();	// Refresh the board
		}

		

		// Redo the move from redo history
		public void RedoMove()
		{
			
			if (ChessGame.ReDoMove())
			{
				LogUserMove("Redo Move");	// Log the user action

				// check if the last move was promo move
				Move move=ChessGame.GetLastMove();	// get the last move 

			
			}
			RedrawBoard();	// Refresh the board
		}

        /// <summary>
        /// Save the current game state to the given file path
        /// </summary>
        /// <param name="filePath"></param>
        public void SaveGame()
        {
            // Show the File Save as dialog and get the target file path
            SaveFileDialog saveAsDialog = new SaveFileDialog();
            saveAsDialog.Title = "Save file as...";
            saveAsDialog.Filter = "Quick Chess File (*.qcf)|*.qcf";
            saveAsDialog.RestoreDirectory = true;

            if (saveAsDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the file at the given path
                ChessGame.SaveGame(saveAsDialog.FileName);
            }
        }

        /// <summary>
        /// Load the current game state from the given file path
        /// </summary>
        /// <param name="filePath"></param>
        public void LoadGame()
        {
            // Show the File Save as dialog and get the target file path
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Load Quick Chess file...";
            openDialog.Filter = "Quick Chess File (*.qcf)|*.qcf";
            openDialog.RestoreDirectory = true;

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                ChessGame = new Game();
                ChessGame.Reset();	// Reset the game board
               

                IsRunning = true;
                LogCounter = 0;

               
                // Save the file at the given path
                ChessGame.LoadGame(openDialog.FileName);

                // Show the player info
                InitPlayers();
              
                // Restore the Log and Capture bar items
                object[] moves = ChessGame.MoveHistory.ToArray();
                for (int i = moves.Length - 1; i >= 0; i--)
                {
                    Move move = (Move)moves[i];

                    // Log this user move
                    LogUserMove(move.ToString());

                  }

                // Restore the menu state
                ParentForm.EnableSaveMenu();
               
             

                RedrawBoard();
                this.result.Clear();
                this.result.Push(InitCounter(ChessGame.Board));
                this.resultBlack.Clear();
                this.resultBlack.Push(InitCounterBlack(ChessGame.Board));
                // Make the chess board visible on screen
            }
        }

		// Initialize a new game and set the pieces on the board
		public void NewGame()
		{
          
				ChessGame = new Game();
                ChessGame.Reset(); // Reset the game board

				IsRunning = true;
				LogCounter = 0;
               

             
				InitPlayers();
				RedrawBoard();		// Make the chess board visible on screen
                this.result.Clear();
                this.result.Push(InitCounter(ChessGame.Board));
                this.resultBlack.Clear();
                this.resultBlack.Push(InitCounterBlack(ChessGame.Board));

			
                // Let user save the game
                ParentForm.EnableSaveMenu();
                
           
		}
	}
}
