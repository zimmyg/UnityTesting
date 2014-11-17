UnityTesting
============

Testing Unity with Git

<h5>Some simple rules:</h5>
<ul>
<li>.meta files must always be committed with their assets</li>
<li>Always open the project in Unity before a commit, to allow it to update metas.</li>
<li>If you add an asset or folder, it’s up to you to commit the meta</li>
<li>Move/delete objects in Unity, not the filesystem, so it updates metas accordingly (git detects these actions correctly, moves actually show up as moves in history)</li>
<li>If you delete an asset or folder, it’s up to you to commit the meta deletion</li>
<li>Always delete folders that no longer contain assets and commit the meta deletion</li>
<li>Notify the team before you push to avoid pushblocking someone that’s doing a large push with something small and trivial.</li>
<li>Ideally when starting on what could be a large/time consuming feature, create a local branch so if you need to switch back to master to fix something small you can</li>
</ul>
