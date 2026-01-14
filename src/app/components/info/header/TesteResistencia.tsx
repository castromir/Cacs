import { EditableField } from "../../editable/EditableField"

type TesteResistenciaProps = {
  label: string
  value: number
  onSave: (value: number) => void
}

export function TesteResistencia({ label, value, onSave }: TesteResistenciaProps) {
  return (
    <li className="flex flex-col items-center">
      <span className="w-10 text-center">{label}</span>

      <EditableField
        value={value}
        type="number"
        onSave={(v) => onSave(v as number)}
        className="w-10 text-center"
      />
    </li>
  )
}