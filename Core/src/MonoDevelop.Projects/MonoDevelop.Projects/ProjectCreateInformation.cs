// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version value="$version"/>
// </file>
using System.IO;
using System.Collections;
using System.Xml;

namespace MonoDevelop.Projects
{
	/// <summary>
	/// This class holds all information the language binding need to create
	/// a predefined project for their language, if no project template for a 
	/// specific language is avaiable, the language binding shouldn't care about
	/// this stuff.
	/// </summary>
	public class ProjectCreateInformation
	{
		string projectName;
		string combineName;
		string combinePath;
		string projectBasePath;
		
		public string ProjectName {
			get {
				return projectName;
			}
			set {
				projectName = value;
			}
		}
		
		public string CombineName {
			get {
				return combineName;
			}
			set {
				combineName = value;
			}
		}
		
		public string BinPath {
			get {
				return Path.Combine(projectBasePath, "bin");
			}
		}
		
		public string CombinePath {
			get {
				return combinePath;
			}
			set {
				combinePath = value;
			}
		}
		
		public string ProjectBasePath {
			get {
				return projectBasePath;
			}
			set {
				projectBasePath = value;
			}
		}
	}
}
