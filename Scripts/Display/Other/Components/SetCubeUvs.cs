﻿//----------------------------------------------
// Flip Web Apps: Game Framework
// Copyright © 2016 Flip Web Apps / Mark Hewitt
//
// Please direct any bugs/comments/suggestions to http://www.flipwebapps.com
// 
// The copyright owner grants to the end user a non-exclusive, worldwide, and perpetual license to this Asset
// to integrate only as incorporated and embedded components of electronic games and interactive media and 
// distribute such electronic game and interactive media. End user may modify Assets. End user may otherwise 
// not reproduce, distribute, sublicense, rent, lease or lend the Assets. It is emphasized that the end 
// user shall not be entitled to distribute or transfer in any way (including, without, limitation by way of 
// sublicense) the Assets in any other way than as integrated components of electronic games and interactive media. 

// The above copyright notice and this permission notice must not be removed from any files.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//----------------------------------------------

using UnityEngine;

namespace FlipWebApps.GameFramework.Scripts.Display.Other.Components
{
    /// <summary>
    /// Set the UV co-ordinates of a cube
    /// </summary>
    /// This component must be applied to a gameobject that has a MeshFilter attached.
    [RequireComponent(typeof(MeshFilter))]
    [AddComponentMenu("Game Framework/Display/Other/SetCubeUvs")]
    [HelpURL("http://www.flipwebapps.com/unity-assets/game-framework/display/")]
    public class SetCubeUvs : MonoBehaviour
    {

        /// <summary>
        /// Whether all faces of the cube should have the same UV's as the front face.
        /// </summary>
        [Tooltip("Whether all faces of the cube should have the same UV's as the front face.")]
        public bool AllSameAsFront;

        /// <summary>
        /// UV's for the front face
        /// </summary>
        [Tooltip("UV's for the front face")]
        public Rect UvsFront;

        /// <summary>
        /// UV's for the back face
        /// </summary>
        [Tooltip("UV's for the back face")]
        public Rect UvsBack;

        /// <summary>
        /// UV's for the left face
        /// </summary>
        [Tooltip("UV's for the left face")]
        public Rect UvsLeft;

        /// <summary>
        /// UV's for the right face
        /// </summary>
        [Tooltip("UV's for the right face")]
        public Rect UvsRight;

        /// <summary>
        /// UV's for the top face
        /// </summary>
        [Tooltip("UV's for the top face")]
        public Rect UvsTop;

        /// <summary>
        /// UV's for the bottom face
        /// </summary>
        [Tooltip("UV's for the bottom face")]
        public Rect UvsBottom;

        Mesh _mesh;
        Vector2[] _Uvs;

        void Awake()
        {
            if (AllSameAsFront)
            {
                UvsBack = UvsFront;
                UvsLeft = UvsFront;
                UvsRight = UvsFront;
                UvsTop = UvsFront;
                UvsBottom = UvsFront;
            }

            _mesh = transform.GetComponent<MeshFilter>().mesh;
            _Uvs = new Vector2[_mesh.uv.Length];
            _Uvs = _mesh.uv;

            SetUVs();
        }

        void SetUVs()
        {
            // - set UV coordinates -

            // FRONT    2    3    0    1
            _Uvs[2] = new Vector2(UvsFront.x, UvsFront.y);
            _Uvs[3] = new Vector2(UvsFront.x + UvsFront.width, UvsFront.y);
            _Uvs[0] = new Vector2(UvsFront.x, UvsFront.y - UvsFront.height);
            _Uvs[1] = new Vector2(UvsFront.x + UvsFront.width, UvsFront.y - UvsFront.height);

            // BACK    6    7   10   11
            _Uvs[6] = new Vector2(UvsBack.x, UvsBack.y);
            _Uvs[7] = new Vector2(UvsBack.x + UvsBack.width, UvsBack.y);
            _Uvs[10] = new Vector2(UvsBack.x, UvsBack.y - UvsBack.height);
            _Uvs[11] = new Vector2(UvsBack.x + UvsBack.width, UvsBack.y - UvsBack.height);

            // LEFT   19   17   16   18
            _Uvs[19] = new Vector2(UvsLeft.x, UvsLeft.y);
            _Uvs[17] = new Vector2(UvsLeft.x + UvsLeft.width, UvsLeft.y);
            _Uvs[16] = new Vector2(UvsLeft.x, UvsLeft.y - UvsLeft.height);
            _Uvs[18] = new Vector2(UvsLeft.x + UvsLeft.width, UvsLeft.y - UvsLeft.height);

            // RIGHT   23   21   20   22
            _Uvs[23] = new Vector2(UvsRight.x, UvsRight.y);
            _Uvs[21] = new Vector2(UvsRight.x + UvsRight.width, UvsRight.y);
            _Uvs[20] = new Vector2(UvsRight.x, UvsRight.y - UvsRight.height);
            _Uvs[22] = new Vector2(UvsRight.x + UvsRight.width, UvsRight.y - UvsRight.height);

            // TOP    4    5    8    9
            _Uvs[4] = new Vector2(UvsTop.x, UvsTop.y);
            _Uvs[5] = new Vector2(UvsTop.x + UvsTop.width, UvsTop.y);
            _Uvs[8] = new Vector2(UvsTop.x, UvsTop.y - UvsTop.height);
            _Uvs[9] = new Vector2(UvsTop.x + UvsTop.width, UvsTop.y - UvsTop.height);

            // BOTTOM   15   13   12   14
            _Uvs[15] = new Vector2(UvsBottom.x, UvsBottom.y);
            _Uvs[13] = new Vector2(UvsBottom.x + UvsBottom.width, UvsBottom.y);
            _Uvs[12] = new Vector2(UvsBottom.x, UvsBottom.y - UvsBottom.height);
            _Uvs[14] = new Vector2(UvsBottom.x + UvsBottom.width, UvsBottom.y - UvsBottom.height);

            // - Assign the mesh its new UVs -
            _mesh.uv = _Uvs;
        }
    }
}