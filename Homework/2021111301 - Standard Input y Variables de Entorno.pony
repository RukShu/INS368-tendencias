actor Main
	new create(env : Env) =>

		//Enviroment Variables
		for envvars in env.vars.values() do
			env.out.print(envvars)
		end

		//Stdin
		var str : String = ""
		var count : I32 = 20
		env.input(
			object iso is InputNotify
				fun ref apply(data : Array[U8] iso) =>
					var char : String = String.from_iso_array(consume data)
					str = str + char
					count = count - 1
					env.out.write(char)
					if count < 0 then 
						env.input.dispose()
					end	
				fun ref dispose() =>
					env.out.print(str)
			end, 512
		)
