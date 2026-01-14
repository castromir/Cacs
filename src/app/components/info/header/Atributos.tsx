"use client" 

import { useFichaStore } from "@/src/app/store/fichaStore"
import { Atributo } from "@/src/app/components/info/header/Atributo";

export function Atributos() {
  const atributos = useFichaStore((state) => state.atributos)
  const setAtributo = useFichaStore((state) => state.setAtributo)

  return (
    <section>
      <ul className="flex gap-4">
        <Atributo
          label="FOR"
          value={atributos.forca}
          onSave={(v) => setAtributo('forca', v)}
        />
        <Atributo
          label="AGI"
          value={atributos.agilidade}
          onSave={(v) => setAtributo('agilidade', v)}
        />
        <Atributo
          label="INS"
          value={atributos.instinto}
          onSave={(v) => setAtributo('instinto', v)}
        />
        <Atributo
          label="INT"
          value={atributos.intelecto}
          onSave={(v) => setAtributo('intelecto', v)}
        />
        <Atributo
          label="VIG"
          value={atributos.vigor}
          onSave={(v) => setAtributo('vigor', v)}
        />
        <Atributo
          label="PRE"
          value={atributos.presenca}
          onSave={(v) => setAtributo('presenca', v)}
        />
      </ul>
    </section>
  )
}

//711.6  327.2
//353.2 881.2
// 500 880.4