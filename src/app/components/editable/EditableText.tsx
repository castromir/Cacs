'use client'

import { EditableField } from './EditableField'

type EditableTextProps = {
  value: string
  onSave: (value: string) => void
  className?: string
}

export function EditableText(props: EditableTextProps) {
  return <EditableField {...props} type="text" />
}
