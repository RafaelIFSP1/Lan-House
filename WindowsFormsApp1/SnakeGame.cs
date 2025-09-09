using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SeuNamespace
{
    public partial class SnakeGame : Form
    {
        private List<Point> snake = new List<Point>();
        private Point food = new Point();
        private Direction currentDirection = Direction.Right;
        private int score = 0;
        private const int tileSize = 20;
        private const int gridSize = 20;
        private Timer gameTimer;
        private bool isGameOver = false;

        private enum Direction { Up, Down, Left, Right }

        public SnakeGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ClientSize = new Size(tileSize * gridSize, tileSize * gridSize);
            this.Text = "Snake Game - Score: 0";
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(SnakeGame_KeyDown);
            this.FormClosing += new FormClosingEventHandler(SnakeGame_FormClosing);

            InitializeGame();
        }

        private void InitializeGame()
        {
            isGameOver = false;
            snake.Clear();
            snake.Add(new Point(5, 10));
            snake.Add(new Point(4, 10));
            snake.Add(new Point(3, 10));

            GenerateFood();
            score = 0;
            this.Text = $"Snake Game - Score: {score}";

            if (gameTimer != null)
            {
                gameTimer.Stop();
                gameTimer.Dispose();
            }

            gameTimer = new Timer();
            gameTimer.Interval = 100;
            gameTimer.Tick += new EventHandler(GameTimer_Tick);
            gameTimer.Start();
        }

        private void GenerateFood()
        {
            Random rand = new Random();
            food = new Point(rand.Next(0, gridSize), rand.Next(0, gridSize));

            while (snake.Contains(food))
            {
                food = new Point(rand.Next(0, gridSize), rand.Next(0, gridSize));
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!isGameOver)
            {
                MoveSnake();
                CheckCollision();
                this.Invalidate();
            }
        }

        private void MoveSnake()
        {
            for (int i = snake.Count - 1; i > 0; i--)
            {
                snake[i] = snake[i - 1];
            }

            Point head = snake[0];
            switch (currentDirection)
            {
                case Direction.Up: head.Y--; break;
                case Direction.Down: head.Y++; break;
                case Direction.Left: head.X--; break;
                case Direction.Right: head.X++; break;
            }
            snake[0] = head;
        }

        private void CheckCollision()
        {
            Point head = snake[0];

            // Colisão com as paredes
            if (head.X < 0 || head.X >= gridSize || head.Y < 0 || head.Y >= gridSize)
            {
                GameOver();
                return;
            }

            // Colisão com o próprio corpo
            for (int i = 1; i < snake.Count; i++)
            {
                if (head == snake[i])
                {
                    GameOver();
                    return;
                }
            }

            // Colisão com a comida
            if (head == food)
            {
                score += 10;
                this.Text = $"Snake Game - Score: {score}";
                snake.Add(snake[snake.Count - 1]);
                GenerateFood();

                // Aumenta a velocidade
                if (score % 50 == 0 && gameTimer.Interval > 50)
                {
                    gameTimer.Interval -= 10;
                }
            }
        }

        private void GameOver()
        {
            if (isGameOver) return;

            isGameOver = true;
            gameTimer.Stop();
            this.Text = $"Snake Game - GAME OVER - Score: {score} - Press R to restart";
            this.Invalidate();
        }

        private void SnakeGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (isGameOver && e.KeyCode == Keys.R)
            {
                InitializeGame();
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    if (currentDirection != Direction.Down) currentDirection = Direction.Up;
                    break;
                case Keys.S:
                case Keys.Down:
                    if (currentDirection != Direction.Up) currentDirection = Direction.Down;
                    break;
                case Keys.A:
                case Keys.Left:
                    if (currentDirection != Direction.Right) currentDirection = Direction.Left;
                    break;
                case Keys.D:
                case Keys.Right:
                    if (currentDirection != Direction.Left) currentDirection = Direction.Right;
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void SnakeGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gameTimer != null)
            {
                gameTimer.Stop();
                gameTimer.Dispose();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Desenha o grid de fundo
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    g.DrawRectangle(Pens.LightGray, x * tileSize, y * tileSize, tileSize, tileSize);
                }
            }

            // Desenha a cobra
            foreach (Point segment in snake)
            {
                g.FillRectangle(Brushes.Green, segment.X * tileSize, segment.Y * tileSize, tileSize, tileSize);
            }

            // Desenha a comida
            g.FillRectangle(Brushes.Red, food.X * tileSize, food.Y * tileSize, tileSize, tileSize);

            // Desenha tela de Game Over
            if (isGameOver)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(180, Color.Black)), 0, 0, this.Width, this.Height);

                Font fontLarge = new Font("Arial", 20, FontStyle.Bold);
                Font fontMedium = new Font("Arial", 14);
                Font fontSmall = new Font("Arial", 10);

                g.DrawString("GAME OVER", fontLarge, Brushes.White, 60, 80);
                g.DrawString($"Score: {score}", fontMedium, Brushes.White, 100, 130);
                g.DrawString("Press R to restart", fontSmall, Brushes.White, 85, 170);
                g.DrawString("Press ESC to exit", fontSmall, Brushes.White, 85, 190);

                fontLarge.Dispose();
                fontMedium.Dispose();
                fontSmall.Dispose();
            }
        }

        private void SnakeGame_Load(object sender, EventArgs e)
        {

        }
    }
}