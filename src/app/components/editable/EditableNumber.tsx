'use client'

import { EditableField } from './EditableField'

type EditableNumberProps = {
  value: number
  onSave: (value: number) => void
  className?: string
}

export function EditableNumber(props: EditableNumberProps) {
  return <EditableField {...props} type="number" />
}
