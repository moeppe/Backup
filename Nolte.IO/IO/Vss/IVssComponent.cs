/* Copyright (c) 2008-2012 Peter Palotas
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy
 *  of this software and associated documentation files (the "Software"), to deal
 *  in the Software without restriction, including without limitation the rights
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *  copies of the Software, and to permit persons to whom the Software is
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in
 *  all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 *  THE SOFTWARE.
 */
using System;
using System.Collections.Generic;

namespace Nolte.IO.Vss
{
   /// <summary>
   /// 	<para>
   /// 		Interface containing methods for examining and modifying information about components contained in a requester's Backup Components Document.
   /// 	</para>
   /// </summary>
   /// <remarks>
   /// 	<para>
   /// 		<see cref="IVssComponent"/> objects can be obtained only for those components that have been explicitly added 
   /// 		to the Backup Components Document during a backup operation by the <see cref="IVssBackupComponents.AddComponent"/> 
   /// 		method.
   /// 	</para>
   /// 	<para>
   /// 		Information about components explicitly added during a restore operation using 
   /// 		<see cref="IVssBackupComponents.AddRestoreSubcomponent"/> are not available through the <see cref="IVssComponent"/>
   /// 		interface.
   /// 	</para>
   /// 	<para>
   /// 		For more information, see <see href="http://msdn.microsoft.com/en-us/library/aa382871(VS.85).aspx">the MSDN documentation on 
   /// 		the IVssComponent Interface</see>.
   /// 	</para>
   /// </remarks>    
   public interface IVssComponent : IDisposable
   {
      #region IVssComponents members

      /// <summary>
      /// 	The <see cref="AdditionalRestores" /> is used by a writer during incremental or differential restore 
      /// 	operations to determine whether a given component will require additional restore operations to completely retrieve it, 
      /// 	but can also be called by a requester.
      /// </summary>
      /// <value>
      ///		If <see langword="true"/>, additional restores will occur for the 
      ///		current component. If <see langword="false"/>, additional restores will not occur.
      /// </value>
      bool AdditionalRestores { get; }

      /// <summary>
      /// 	<para>
      /// 		The backup options specified to the writer that manages the currently selected component or component set 
      /// 		by a requester using <see cref="IVssBackupComponents.SetBackupOptions"/>.
      /// 	</para>
      /// </summary>
      /// <value>The backup options for the current writer.</value>
      string BackupOptions { get; }

      /// <summary>The backup stamp string stored by a writer for a given component.</summary>
      /// <value>The backup stamp indicating the time at which the component was backed up.</value>
      string BackupStamp { get; }

      /// <summary>
      /// 	The status of a complete attempt at backing up all the files of a selected component or component set as a 
      /// 	<see cref="VssFileRestoreStatus"/> enumeration.
      /// </summary>
      /// <value>
      /// 	<see langword="true"/> if the backup was successful and <see langword="false"/> if it was not.
      /// </value>
      bool BackupSucceeded { get; }

      /// <summary>The logical name of this component.</summary>
      /// <value>The logical name of this component.</value>
      string ComponentName { get; }

      /// <summary>The type of this component in terms of the <see cref="ComponentType"/> enumeration.</summary>
      /// <value>The type of this component.</value>
      VssComponentType ComponentType { get; }

      /// <summary>
      /// 	The status of a completed attempt to restore all the files of a selected component or component set 
      /// 	as a <see cref="VssFileRestoreStatus" /> enumeration.
      /// </summary>
      /// <value>
      /// 	A value of the <see cref="VssFileRestoreStatus" /> enumeration that specifies whether all files were successfully restored.
      /// </value>		
      VssFileRestoreStatus FileRestoreStatus { get; }

      /// <summary>The logical path of this component.</summary>
      /// <value>The logical path of this component.</value>
      string LogicalPath { get; }

      /// <summary>The failure message generated by a writer while handling the <c>PostRestore</c> event if one was set.</summary>
      /// <value>The failure message that describes an error that occurred while processing the <c>PostRestore</c> event.</value>
      string PostRestoreFailureMsg { get; }

      /// <summary>The failure message generated by a writer while handling the <c>PreRestore</c> event if one was set.</summary>
      /// <value>The failure message that describes an error that occurred while processing the <c>PreRestore</c> event.</value>
      string PreRestoreFailureMsg { get; }

      /// <summary>
      /// 	A previous backup stamp loaded by a requester in the Backup Components Document. The value is used by a writer when 
      /// 	deciding if files should participate in differential or incremental backup operation.
      /// </summary>
      /// <value>
      /// 	The time stamp of a previous backup so that a differential or incremental backup can be correctly implemented.
      /// </value>
      string PreviousBackupStamp { get; }

      /// <summary>The restore options specified to the current writer by a requester using 
      /// <see cref="IVssBackupComponents.SetRestoreOptions"/>.</summary>
      /// <value>The restore options of the writer.</value>
      string RestoreOptions { get; }

      /// <summary>The restore target (in terms of the <see cref="VssRestoreTarget"/> enumeration) for the current component. Can only be called during a restore operation.</summary>
      /// <value>A value from the <see cref="VssRestoreTarget"/> enumeration containing the restore target information.</value>
      VssRestoreTarget RestoreTarget { get; }

      /// <summary>Determines whether the current component has been selected to be restored.</summary>
      /// <value>If the returned value of this parameter is <see langword="true"/>, the component has been selected to be restored. If <see langword="false"/>, it has not been selected.</value>
      bool IsSelectedForRestore { get; }

      /// <summary>A collection of mapping information for the file set's alternate location for file restoration.</summary>
      /// <value>A read-only list containing the alternate location to which files were actually restored. <note type="caution">This list must not be accessed after the <see cref="IVssComponent"/> from which it was obtained has been disposed.</note></value>
      /// <remarks>See <see href="http://msdn.microsoft.com/en-us/library/aa383473(VS.85).aspx">the MSDN documentation on the IVssComponent::GetAlternateLocationMapping method</see> for more information.</remarks>
      IList<VssWMFileDescriptor> AlternateLocationMappings { get; }

      /// <summary>
      /// 	Information stored by a writer, at backup time, to the Backup Components Document to indicate that when a file is to be 
      /// 	restored, it (the source file) should be remapped. The file may be restored to a new restore target and/or ranges of its data 
      /// 	restored to different locations with the restore target.
      /// </summary>
      /// <value>A read-only list containing the directed targets of this component. <note type="caution">This list must not be accessed after the <see cref="IVssComponent"/> from which it was obtained has been disposed.</note></value>
      IList<VssDirectedTargetInfo> DirectedTargets { get; }

      /// <summary>
      /// 	The new file restoration locations for the selected component or component set. 
      /// </summary>
      /// <value>A read-only list contianing the new file restoration locations for the selected component or component set. <note type="caution">This list must not be accessed after the <see cref="IVssComponent"/> from which it was obtained has been disposed.</note></value>
      IList<VssWMFileDescriptor> NewTargets { get; }

      /// <summary>
      ///		Information about any partial files associated with this component.
      /// </summary>
      /// <value>A read-only list containing information about any partial files associated with this component. <note type="caution">This list must not be accessed after the <see cref="IVssComponent"/> from which it was obtained has been disposed.</note></value>
      IList<VssPartialFileInfo> PartialFiles { get; }

      /// <summary>
      /// 	Information about the file sets (specified file or files) to participate in an incremental or differential backup or restore as a 
      /// 	differenced file — that is, backup and restores associated with it are to be implemented as if entire files are copied to and from 
      /// 	backup media (as opposed to using partial files).
      /// </summary>
      /// <remarks><b>Windows XP:</b> This method requires Windows Server 2003 or later</remarks>
      /// <value>
      /// 	A read only list containing the diffrenced files associated with this component. <note type="caution">This list must not be accessed after the <see cref="IVssComponent"/> from which it was obtained has been disposed.</note>
      /// </value>
      IList<VssDifferencedFileInfo> DifferencedFiles { get; }

      /// <summary>The subcomponents associated with this component.</summary>
      /// <value>A read only list containing the subcomponents associated with this component. <note type="caution">This list must not be accessed after the <see cref="IVssComponent"/> from which it was obtained has been disposed.</note></value>
      IList<VssRestoreSubcomponentInfo> RestoreSubcomponents { get; }

      #endregion

      #region IVssComponentsEx members

      /// <summary>
      /// Gets a value indicating whether a requester has marked the restore of a component as authoritative for a replicated data store.
      /// </summary>
      /// <value>
      /// 	<see langword="true"/> if the restore is authoritative; otherwise, <see langword="false"/>.
      /// </value>
      /// <remarks>
      /// <para>
      ///     A writer indicates that it supports authoritative restore by setting the 
      ///     <see cref="VssBackupSchema.AuthoritativeRestore"/> flag in its backup schema mask.
      /// </para>
      /// <para>
      ///     For more information, see <see href="http://msdn.microsoft.com/en-us/library/aa384610(VS.85).aspx">Setting VSS Restore Options.</see>
      /// </para>
      /// <para>
      ///     <note>
      ///         <para>
      ///             <b>Windows XP and Windows 2003:</b> This property requires Windows Vista or later and will always return <see langword="false"/> 
      ///             on unsupported operating systems.
      ///         </para>
      ///     </note>
      /// </para>
      /// </remarks>
      bool IsAuthoritativeRestore { get; }

      /// <summary>
      /// Gets the <c>PostSnapshot</c> failure message string that a writer has set for a given component.
      /// </summary>
      /// <remarks>
      ///     <para>
      ///         Both writers and requesters can call this method.
      ///     </para>
      ///     <para>
      ///     <note>
      ///         <para>
      ///             <b>Windows XP and Windows 2003:</b> This property requires Windows Vista or later and will always return <see langword="false"/> 
      ///             on unsupported operating systems.
      ///         </para>
      ///     </note>
      ///     </para>
      /// </remarks>
      /// <value>A string containing the failure message that describes an error that occurred while processing a PostSnapshot event, or <see langword="null"/> 
      /// if no value was set or the method is not supported on the current operating system.</value>
      string PostSnapshotFailureMsg { get; }

      /// <summary>
      /// Gets the <c>PrepareForBackup</c> failure message string that a writer has set for a given component.
      /// </summary>
      /// <value>A string containing the failure message that describes an error that occurred while processing a PrepareForBackup event,
      /// or <see langword="null"/> if no failure message was set for this component, or if the property is not supported on the 
      /// current operating system.</value>
      /// <remarks>
      ///     <para>
      ///         Both writers and requesters can call this method.
      ///     </para>
      ///     <para>
      ///     <note>
      ///         <para>
      ///             <b>Windows XP and Windows 2003:</b> This property requires Windows Vista or later and will always return <see langword="false"/> 
      ///             on unsupported operating systems.
      ///         </para>
      ///     </note>
      ///     </para>
      /// </remarks>
      string PrepareForBackupFailureMsg { get; }

      /// <summary>
      /// Obtains the logical name assigned to a component that is being restored.
      /// </summary>
      /// <value>
      ///     A string containing the restore name for the component, or <see langword="null"/> if the operation
      ///     is not supported on the current operating system.
      /// </value>
      /// <remarks>
      ///     <para>
      ///         The <see cref="RestoreName"/> property can only be accessed during a restore operation.
      ///     </para>
      ///     <para>
      ///         A writer indicates that it supports this method by setting the <see cref="VssBackupSchema.RestoreRename"/> 
      ///         flag in its backup schema mask.
      ///     </para>
      ///     <para>
      ///         For more information, see <see href="http://msdn.microsoft.com/en-us/library/aa384610(VS.85).aspx">
      ///         Setting VSS Restore Options</see>.
      ///     </para>
      ///     <para>
      ///     <note>
      ///         <para>
      ///             <b>Windows XP and Windows 2003:</b> This property requires Windows Vista or later and will always return <see langword="false"/> 
      ///             on unsupported operating systems.
      ///         </para>
      ///     </note>
      ///     </para>
      /// </remarks>
      string RestoreName { get; }


      /// <summary>
      ///     Obtains the restore point for a partial roll-forward operation.
      /// </summary>
      /// <value>
      ///     A string specifying the roll-forward restore point,
      ///     or <see langword="null"/> if the property is not supported in the current context.
      /// </value>
      /// <remarks>
      ///     <para>
      ///         The <see cref="RollForwardRestorePoint"/> property can only be accessed during a restore operation.
      ///     </para>
      ///     <para>
      ///         A writer indicates that it supports this method by setting the <see cref="VssBackupSchema.RollForwardRestore"/> 
      ///         flag in its backup schema mask.
      ///     </para>
      ///     <para>
      ///         For more information, see <see href="http://msdn.microsoft.com/en-us/library/aa384610(VS.85).aspx">
      ///         Setting VSS Restore Options</see>.
      ///     </para>
      ///     <para>
      ///     <note>
      ///         <para>
      ///             <b>Windows XP and Windows 2003:</b> This property requires Windows Vista or later and will always return <see cref="VssRollForwardType.Undefined"/>
      ///             on unsupported operating systems.
      ///         </para>
      ///     </note>
      ///     </para>
      /// </remarks>        
      string RollForwardRestorePoint { get; }

      /// <summary>
      ///     Obtains the roll-forward operation type for a component.
      /// </summary>
      /// <value>
      ///     A <see cref="VssRollForwardType"/> enumeration value indicating the type of roll-forward operation to be performed,
      ///     or <see cref="VssRollForwardType.Undefined"/> if the property is not supported in the current context.
      /// </value>
      /// <remarks>
      ///     <para>
      ///         The <see cref="RollForwardType"/> property can only be accessed during a restore operation.
      ///     </para>
      ///     <para>
      ///         A writer indicates that it supports this method by setting the <see cref="VssBackupSchema.RollForwardRestore"/> 
      ///         flag in its backup schema mask.
      ///     </para>
      ///     <para>
      ///         For more information, see <see href="http://msdn.microsoft.com/en-us/library/aa384610(VS.85).aspx">
      ///         Setting VSS Restore Options</see>.
      ///     </para>
      ///     <para>
      ///     <note>
      ///         <para>
      ///             <b>Windows XP and Windows 2003:</b> This property requires Windows Vista or later and will always return <see cref="VssRollForwardType.Undefined"/>
      ///             on unsupported operating systems.
      ///         </para>
      ///     </note>
      ///     </para>
      /// </remarks>
      VssRollForwardType RollForwardType { get; }

      #endregion

      #region IVssComponentsEx2 members

      /// <summary>
      /// VSS requesters read this property to retrieve component-level errors reported by writers. 
      /// VSS writers set this property to report errors at the component level.
      /// </summary>
      /// <returns>An instance of <see cref="VssComponentFailure"/> containing the information reported by the writer.</returns>
      /// <remarks>Minimum supported client: Windows 7, Minimum supported server: Windows Server 2008 R2</remarks>
      /// <exception cref="VssBadStateException">The backup components object is not initialized, this method has been called during a restore operation, or this method has not been called within the correct sequence.</exception>
      VssComponentFailure Failure { get; set; }

      #endregion

#if false // These methods may only be called by writers, only supporting requesters for now so these are not included.
        void SetPrepareForBackupFailureMsg(string message);
        void SetPostSnapshotFailureMsg(string message);
#endif
   }
}