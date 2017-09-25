// -----------------------------------------------------------------------
// <copyright file="IMeshFormat.cs" company="">
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

namespace UnityEditor.U2D.TriangleNet.IO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
	using UnityEditor.U2D.TriangleNet.Geometry;

    /// <summary>
    /// Interface for mesh I/O.
    /// </summary>
    public interface IMeshFormat
    {
        /// <summary>
        /// Read a file containing a mesh.
        /// </summary>
        /// <param name="filename">The path of the file to read.</param>
        /// <returns>An instance of the <see cref="Mesh" /> class.</returns>
        Mesh Import(string filename);

        /// <summary>
        /// Save a mesh to disk.
        /// </summary>
        /// <param name="mesh">An instance of the <see cref="Mesh" /> class.</param>
        /// <param name="filename">The path of the file to save.</param>
        void Write(Mesh mesh, string filename);
    }
}
