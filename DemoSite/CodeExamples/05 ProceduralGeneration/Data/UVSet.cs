using UnityEngine;

namespace eWolf.CodeExamples.ProceduralGeneration
{
    public class UVSet
    {
        /// <summary>
        /// The Bottom left position
        /// </summary>
        public Vector2 BL;

        /// <summary>
        /// The bottom right postion
        /// </summary>
        public Vector2 BR;

        /// <summary>
        /// The top left position
        /// </summary>
        public Vector2 TL;

        /// <summary>
        /// The top right position
        /// </summary>
        public Vector2 TR;

        /// <summary>
        /// The Standard constructor
        /// </summary>
        /// <param name="topLeft">The top left UV</param>
        /// <param name="topRight">The top right UV</param>
        /// <param name="botLeft">The bottom left uv</param>
        /// <param name="botRight">The bottom right uv</param>
        public UVSet(Vector2 topLeft, Vector2 topRight, Vector2 botLeft, Vector3 botRight)
        {
            TL = topLeft;
            TR = topRight;
            BL = botLeft;
            BR = botRight;
        }

        /// <summary>
        /// The Standard constructor
        /// </summary>
        public UVSet()
        {
        }

        /// <summary>
        /// The Standard constructor
        /// </summary>
        /// <param name="x">The X position</param>
        /// <param name="y">The Y position</param>
        public UVSet(float x, float y)
        {
            TL = new Vector2(0, 0);
            TR = new Vector2(0, y);
            BL = new Vector2(x, 0);
            BR = new Vector2(x, y);
        }
    }
}