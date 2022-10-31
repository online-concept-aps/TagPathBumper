# Tag Path Bumper

```powershell
    $version = "0.0.4"
    git add .
    git commit -m "commit message"
    git tag -a -m "My release message" v$version
    git push -u origin main --follow-tags
```
