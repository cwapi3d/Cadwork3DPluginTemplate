# Copyright (C) 2023 Cadwork Informatique Inc.

$target_path = $args[0]
$project_dir = $args[1]

$plugin_dir = "$cwuserprofilepath$/$projectname$"

if (!(Test-Path -Path $plugin_dir)) {
  Write-Host "Creating plugin folder..."

  $null = New-Item -Path $plugin_dir -ItemType Directory
}

Write-Host "Copying plugin..."

Copy-Item $target_path -Destination $plugin_dir

Write-Host "Copying auxiliary files..."

if (Test-Path -Path "$project_dir/icon.png") {
  Copy-Item -Force "$project_dir/icon.png" -Destination $plugin_dir
}

if (Test-Path -Path "$project_dir/icon.svg") {
  Copy-Item -Force "$project_dir/icon.svg" -Destination $plugin_dir
}

if (Test-Path -Path "$project_dir/plugin_info.xml") {
  Copy-Item -Force "$project_dir/plugin_info.xml" -Destination $plugin_dir
}

Write-Host "Done..."
