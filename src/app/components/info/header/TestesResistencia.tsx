"use client" 

import { useFichaStore } from "@/src/app/store/fichaStore"
import { EditableField } from "../../editable/EditableField"
import { TesteResistencia } from "@/src/app/components/info/header/TesteResistencia";

export function TestesResistencia() {
  const testesResistencia = useFichaStore((state) => state.testesResistencia)
  const setTesteResistencia = useFichaStore((state) => state.setTesteResistencia)

  return (
    <section>
      <ul className="flex gap-4">
        <TesteResistencia
          label="FRT"
          value={testesResistencia.fortitude}
          onSave={(v) => setTesteResistencia('fortitude', v)}
        />
        <TesteResistencia
          label="REF"
          value={testesResistencia.reflexos}
          onSave={(v) => setTesteResistencia('reflexos', v)}
        />
        <TesteResistencia
          label="VON"
          value={testesResistencia.vontade}
          onSave={(v) => setTesteResistencia('vontade', v)}
        />
      </ul>
    </section>
  )
}