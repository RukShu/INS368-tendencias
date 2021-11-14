actor Main
	new create(env : Env) => 
		for arg in env.args.values() do
			env.out.write(arg)
		end
		env.out.print("")
		env.out.print("Stdout")
		env.err.print("Stderr")
		var count : I32 = 20
		var str : String = ""
		env.input(
			object iso is InputNotify
				fun ref apply(data : Array[U8] iso) =>
					var char : String = String.from_iso_array(consume data)
					str = str + char
					env.out.write(char)
					count = count - 1
					if count < 0 then
						env.input.dispose()
					end

				fun ref dispose() =>
					env.out.print(str)
				end, 512
		)