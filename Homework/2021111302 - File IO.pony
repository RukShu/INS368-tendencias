use "files"

actor Main
	new create (env : Env) =>

	let caps = recover val FileCaps.>set(FileWrite).>set(FileRead).>set(FileStat) end

	try
		with file = OpenFile( FilePath(env.root as AmbientAuth, "text.txt", caps)) as File do
			for line in file.lines() do
				env.out.print(line.string())
			end
		end
	else
		env.out.print("Couldn't open the file.")
	end

	let caps2 = recover val FileCaps.>set(FileWrite).>set(FileRead).>set(FileStat).>set(FileSeek) end

	try
		with file = CreateFile( FilePath(env.root as AmbientAuth, "text.txt", caps2)) as File do
			file.seek_end(0)
			file.write("\nText this is.")
		end
	else
		env.out.print("Couldn't open the file.")
	end