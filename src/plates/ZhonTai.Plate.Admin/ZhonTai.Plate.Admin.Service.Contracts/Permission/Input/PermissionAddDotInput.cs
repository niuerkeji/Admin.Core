using ZhonTai.Plate.Admin.Domain.Permission;

namespace ZhonTai.Plate.Admin.Service.Permission.Input
{
    public class PermissionAddDotInput
    {
        /// <summary>
        /// Ȩ������
        /// </summary>
        public PermissionTypeEnum Type { get; set; } = PermissionTypeEnum.Dot;

        /// <summary>
        /// �����ڵ�
        /// </summary>
        public long ParentId { get; set; }

        /// <summary>
        /// �����ӿ�
        /// </summary>
        public long[] ApiIds { get; set; }

        /// <summary>
        /// Ȩ������
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Ȩ�ޱ���
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// ˵��
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ͼ��
        /// </summary>
        public string Icon { get; set; }
    }
}