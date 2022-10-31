# Tag Path Bumper

```powershell
    $version = 0.0.2
    git add .
    git commit -m "commit message"
    git tag -a -m "My second action release" v$version
    git push -u origin main --follow-tags
```
