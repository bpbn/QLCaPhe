package POJO;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class frmTrangChu {
    private JButton btnBanHang;
    private JButton btnNhapHang;
    private JButton btnThongKe;
    private JPanel pnTrangChu;
    private JPanel panel;

    private frmBanHang frmBanHang;
    public frmTrangChu(){
        //set giao diện
        // Thiết lập layout cho pnTrangChu để giữ cố định các nút button
        pnTrangChu.setLayout(new BorderLayout());

        // Tạo panel để chứa các nút button và sử dụng BoxLayout để sắp xếp theo chiều dọc
        JPanel buttonPanel = new JPanel();
        buttonPanel.setLayout(new BoxLayout(buttonPanel, BoxLayout.Y_AXIS));

        // Thêm các nút vào buttonPanel
        buttonPanel.add(Box.createVerticalStrut(5)); // Khoảng cách 5mm
        buttonPanel.add(btnBanHang);
        buttonPanel.add(Box.createVerticalStrut(5)); // Khoảng cách 5mm
        buttonPanel.add(btnNhapHang);
        buttonPanel.add(Box.createVerticalStrut(5)); // Khoảng cách 5mm
        buttonPanel.add(btnThongKe);
        buttonPanel.add(Box.createVerticalStrut(5)); // Khoảng cách 5mm

        // Thêm buttonPanel vào pnTrangChu
        pnTrangChu.add(buttonPanel, BorderLayout.WEST); // Đặt buttonPanel ở phía bên trái
        pnTrangChu.add(panel, BorderLayout.CENTER);

        panel.setLayout(new BorderLayout());
        btnBanHang.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                panel.removeAll();
                frmBanHang frm1 = new frmBanHang();
                panel.add(frm1.getPnBanHang(), BorderLayout.CENTER);
                panel.revalidate();
                panel.repaint();
            }
        });
    }

    public static void main(String[] args){
        JFrame frame = new JFrame("Cà phê");
        frame.setContentPane(new frmTrangChu().pnTrangChu);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.pack();
        frame.setSize(800, 600);
        frame.setLocationRelativeTo(null);
        frame.setVisible(true);
    }
}
